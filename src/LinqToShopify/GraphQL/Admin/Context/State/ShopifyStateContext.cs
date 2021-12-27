using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using LinqToGraphQL.Client;
using LinqToShopify.Exceptions;

namespace LinqToShopify.GraphQL.Admin.Context.State
{
	public class ShopifyStateContext : ShopifyBaseContext
	{
		internal ShopifyStateContext(string myShopifyName, string authorization) : base(new Dictionary<string, object>
		{
			["MyShopifyName"] = myShopifyName,
			["Authorization"] = authorization
		})
		{
		}
		
		public async Task<bool> Uninstall()
		{
			var uriBuilder = BuildShopUriBuilder(ContextArguments.FirstOrDefault(e => e.Key == "MyShopifyName").Value.ToString());

			uriBuilder.Path = "admin/api_permissions/current.json";
            
			StringContent jsonContent = new StringContent("", Encoding.UTF8, "application/json");

			var httpClientFactory = ClientFactorySingleton.Instance.HttpClientFactory;

			var httpClient = httpClientFactory.CreateClient("shopify_uninstall");

			HttpRequestHeaders headers = httpClient.DefaultRequestHeaders;

			headers.Add("X-Shopify-Access-Token", ContextArguments.FirstOrDefault(e => e.Key == "MyShopifyName").Value.ToString());

			try
			{
				var response = await httpClient.SendAsync(new HttpRequestMessage
				{
					RequestUri = uriBuilder.Uri,
					Content = jsonContent,
					Method = HttpMethod.Post,
                    
				});
                
				return response.StatusCode == HttpStatusCode.OK;
			}
			catch (HttpRequestException exception)
			{
				throw new ShopifyHttpException("An error happened while requesting a Shopify App Access token", exception);
			}
		}
	}
}