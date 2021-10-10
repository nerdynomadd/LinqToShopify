using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using LinqToShopify.GraphQL.Admin.Context.Installation.Types.Authorization.Enum;

namespace LinqToShopify.GraphQL.Admin.Context.Installation
{
    public class ShopifyAuthorizationContext : ShopifyBaseContext
    {
        public ShopifyAuthorizationContext(string myShopifyName, string authorization) : base(new Dictionary<string, object>
        {
            ["MyShopifyName"] = myShopifyName,
            ["Authorization"] = authorization
        })
        {
        }

        public Uri BuildInstallationUrl(List<AuthorizationScopes> scopes,
            string redirectUrl,
            string state = null)
        {
            return BuildInstallationUrl(scopes, redirectUrl, state, null);
        }

        public Uri BuildInstallationUrl(List<AuthorizationScopes> scopes,
            string redirectUrl,
            List<string> grants = null)
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
                
                var memberEnumAttribute = e.GetType().GetCustomAttribute<EnumMemberAttribute>();

                if (memberEnumAttribute is not null)
                {
                    name = memberEnumAttribute.Value;
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
            var uriBuilder = BuildShopUriBuilder("");

            var queryParameters = new List<(string, string)>
            {
                ("client_id", (string) ContextArguments.FirstOrDefault(e => e.Key == "Authorization").Value),
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