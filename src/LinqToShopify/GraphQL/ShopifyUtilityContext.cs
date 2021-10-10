using LinqToShopify.GraphQL.Admin.Context.Installation;

namespace LinqToShopify.GraphQL
{
	public class ShopifyUtilityContext
	{
		private readonly string _myShopifyName;

		public ShopifyUtilityContext(string myShopifyName)
		{
			_myShopifyName = myShopifyName;
		}
		
		public ShopifyAuthorizationContext Authorization(string appApiKey)
		{
			return new ShopifyAuthorizationContext(_myShopifyName, appApiKey);
		}
	}
}