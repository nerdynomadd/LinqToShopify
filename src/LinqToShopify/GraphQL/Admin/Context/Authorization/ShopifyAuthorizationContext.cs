using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Reflection;
using System.Runtime.Serialization;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using LinqToGraphQL.Client;
using LinqToShopify.Exceptions;
using LinqToShopify.GraphQL.Admin.Context.App.Types.Publication;
using LinqToShopify.GraphQL.Admin.Context.Installation.Types.Authorization;
using LinqToShopify.GraphQL.Admin.Context.Installation.Types.Authorization.Enum;
using IHttpClientFactory = HttpClientFactoryLite.IHttpClientFactory;

namespace LinqToShopify.GraphQL.Admin.Context.Installation
{
    public class ShopifyAuthorizationContext : ShopifyBaseContext
    {
        internal ShopifyAuthorizationContext(string myShopifyName, string shopifyAppApiKey) : base(new Dictionary<string, object>
        {
            ["MyShopifyName"] = myShopifyName,
            ["ShopifyAppApiKey"] = shopifyAppApiKey
        })
        {
        }
        
        internal ShopifyAuthorizationContext(string myShopifyName, string shopifyAppApiKey, string shopifyAppApiSecretKey) : base(new Dictionary<string, object>
        {
            ["MyShopifyName"] = myShopifyName,
            ["ShopifyAppApiKey"] = shopifyAppApiKey,
            ["ShopifyAppApiSecretKey"] = shopifyAppApiSecretKey
        })
        {
        }

        public bool CheckInstallationSecurity(string query,
            string appPrivateKey,
            string nonce = "")
        {
            var splitted = query.Split("&");
            
            Dictionary<string, string> queryParameters = splitted.Select(e =>
                {
                    var index = e.IndexOf("=");
                    var x1 = e.Substring(0, index);
                    var x2 = e.Substring(index+1, e.Length-index-1);
                    
                    return (x1, x2);
                })
                .ToDictionary(e => e.Item1, e => e.Item2);

            var nonceParameter = queryParameters.FirstOrDefault(e => e.Key.Contains("nonce")).Value;

            if (!string.IsNullOrEmpty(nonce) && nonceParameter is not null && nonceParameter != nonce)
            {
                return false;
            }

            return CheckHmacValidity(queryParameters, appPrivateKey);
        }
        
        public bool CheckInstallationSecurity(Dictionary<string, string> queryParameters, string appPrivateKey, string nonce = "")
        {
            var nonceParameter = queryParameters.FirstOrDefault(e => e.Key.Contains("nonce")).Value;

            if (!string.IsNullOrEmpty(nonce) && nonceParameter is not null && nonceParameter != nonce)
            {
                return false;
            }

            return CheckHmacValidity(queryParameters, appPrivateKey);
        }

        public bool CheckHmacValidity(string query, string appPrivateKey)
        {
            Dictionary<string, string> queryParameters = 
                query.Split("&")
                    .Select(e => (e.Substring(0, e.IndexOf("=")), e.Substring(e.IndexOf("="), e.Length)))
                .ToDictionary(e => e.Item1, e => e.Item2);

            return CheckHmacValidity(queryParameters, appPrivateKey);
        }

        public bool CheckHmacValidity(Dictionary<string, string> queryParameters, string appPrivateKey)
        {
            var hmac = queryParameters.FirstOrDefault(e => e.Key == "hmac").Value;

            queryParameters.Remove("hmac");

            if (hmac is null)
            {
                return false;
            }

            var encoding = new ASCIIEncoding();

            byte[] keyByte = encoding.GetBytes(appPrivateKey);

            byte[] messageBytes = encoding.GetBytes(string.Join("&", queryParameters));

            using var hmacSha256 = new HMACSHA256(keyByte);

            hmacSha256.Key = keyByte;
            
            byte[] hashMessage = hmacSha256.ComputeHash(messageBytes);

            var result = BitConverter.ToString(hashMessage).Replace("-", "");
            
            return result.ToUpper() == hmac.ToUpper();
        }

        public async Task<AuthorizationResult> AuthorizeInstallation(string code)
        {
            var uriBuilder = BuildShopUriBuilder(ContextArguments.FirstOrDefault(e => e.Key == "MyShopifyName").Value.ToString());

            uriBuilder.Path = "admin/oauth/access_token";
            
            StringContent jsonContent = new StringContent(JsonSerializer.Serialize(new
            {
                client_id = (string) ContextArguments.FirstOrDefault(e => e.Key == "ShopifyAppApiKey").Value,
                client_secret = (string) ContextArguments.FirstOrDefault(e => e.Key == "ShopifyAppApiSecretKey").Value,
                code
            }), Encoding.UTF8, "application/json");
            
            var httpClientFactory = ClientFactorySingleton.Instance.HttpClientFactory;

            var httpClient = httpClientFactory.CreateClient("shopify_installation_authorization");

            try
            {
                var response = await httpClient.SendAsync(new HttpRequestMessage
                {
                    RequestUri = uriBuilder.Uri,
                    Content = jsonContent,
                    Method = HttpMethod.Post
                });

                var responseContent = await response.Content.ReadAsStringAsync();

                return JsonSerializer.Deserialize<AuthorizationResult>(responseContent);
            }
            catch (HttpRequestException exception)
            {
                throw new ShopifyHttpException("An error happened while requesting a Shopify App Access token", exception);
            }
        }

        public Uri BuildInstallationUrl(List<AuthorizationScopes> scopes,
            string redirectUrl)
        {
            return BuildInstallationUrl(scopes, redirectUrl, null, null);
        }

        public Uri BuildInstallationUrl(List<AuthorizationScopes> scopes,
            string redirectUrl,
            string state)
        {
            return BuildInstallationUrl(scopes, redirectUrl, state, null);
        }

        public Uri BuildInstallationUrl(List<AuthorizationScopes> scopes,
            string redirectUrl,
            List<string> grants)
        {
            return BuildInstallationUrl(scopes, redirectUrl, null, grants);
        }
        
        public Uri BuildInstallationUrl(List<AuthorizationScopes> scopes,
            string redirectUrl,
            string state = null,
            List<string> grants = null)
        {

            var authorizationScopes = scopes.Select(e =>
            {
                var name = e.ToString();

                var enumMemberType = e.GetType()
                    .GetMember(e.ToString());

                if (enumMemberType.Any())
                {
                    var enumMemberTypeAttribute = enumMemberType[0]?.GetCustomAttribute<EnumMemberAttribute>();

                    if (enumMemberTypeAttribute is not null)
                    {
                        name = enumMemberTypeAttribute.Value;
                    }   
                }

                return name?.ToLower();
            }).ToList();
             
            return BuildInstallationUrl(authorizationScopes, redirectUrl, state, grants);
        }

        protected Uri BuildInstallationUrl(List<string> scopes,
            string redirectUrl,
            string state = null,
            List<string> grants = null)
        {
            var uriBuilder = BuildShopUriBuilder(ContextArguments.FirstOrDefault(e => e.Key == "MyShopifyName").Value.ToString());

            var queryParameters = new List<(string, string)>
            {
                ("client_id", (string) ContextArguments.FirstOrDefault(e => e.Key == "ShopifyAppApiKey").Value),
                ("scope", string.Join(",", scopes)),
                ("redirect_uri", redirectUrl)
            };
            
            if(!string.IsNullOrEmpty(state))
                queryParameters.Add(("state", state));
            
            if(grants is not null &&  grants.Any())
                foreach (var grant in grants)
                {
                    queryParameters.Add(("grant_options[]", grant));
                }

            uriBuilder.Path = "admin/oauth/authorize";
            uriBuilder.Query = string.Join("&", string.Join("&", queryParameters.Select(e => $"{e.Item1}={e.Item2}")));

            return uriBuilder.Uri;
        }
    }
}