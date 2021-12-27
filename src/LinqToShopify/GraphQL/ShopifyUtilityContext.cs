using LinqToShopify.GraphQL.Admin.Context.Installation;
using LinqToShopify.GraphQL.Admin.Context.State;

namespace LinqToShopify.GraphQL
{
	public class ShopifyUtilityContext
	{
		private readonly string _myShopifyName;

		public ShopifyUtilityContext(string myShopifyName)
		{
			_myShopifyName = myShopifyName;
		}

		public ShopifyStateContext State(string authorization)
		{
			return new ShopifyStateContext(_myShopifyName, authorization);
		}
		
		public ShopifyAuthorizationContext Authorization(string appApiKey)
		{
			return new ShopifyAuthorizationContext(_myShopifyName, appApiKey);
		}
		
		public ShopifyAuthorizationContext Authorization(string appApiKey, string appApiSecretKey)
		{
			return new ShopifyAuthorizationContext(_myShopifyName, appApiKey, appApiSecretKey);
		}
	}
}