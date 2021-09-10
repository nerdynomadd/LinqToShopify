using LinqToShopify.GraphQL.Admin.Context.App;
using LinqToShopify.GraphQL.Admin.Context.Billing;
using LinqToShopify.GraphQL.Admin.Context.Inventory;
using LinqToShopify.GraphQL.Admin.Context.Metafield;
using LinqToShopify.GraphQL.Admin.Context.OnlineStore;
using LinqToShopify.GraphQL.Admin.Context.ProductCollection;
using LinqToShopify.GraphQL.Admin.Context.Translation;

namespace LinqToShopify.GraphQL
{
	public class ShopifyContext
	{
		private readonly string _myShopifyName;

		private readonly string _authorization;
		
		public ShopifyContext(string myShopifyName, string authorization) : base()
		{
			_myShopifyName = myShopifyName;

			_authorization = authorization;
		}

		public ShopifyBillingContext Billing()
		{
			return new ShopifyBillingContext(_myShopifyName, _authorization);
		}

		public ShopifyTranslationContext Translation()
		{
			return new ShopifyTranslationContext(_myShopifyName, _authorization);
		}

		public ShopifyProductContext Product()
		{
			return new ShopifyProductContext(_myShopifyName, _authorization);
		}

		public ShopifyOnlineStoreContext OnlineStore()
		{
			return new ShopifyOnlineStoreContext(_myShopifyName, _authorization);
		}

		public ShopifyMetafieldContext Metafield()
		{
			return new ShopifyMetafieldContext(_myShopifyName, _authorization);
		}

		public ShopifyInventoryContext Inventory()
		{
			return new ShopifyInventoryContext(_myShopifyName, _authorization);
		}

		public ShopifyAppContext App()
		{
			return new ShopifyAppContext(_myShopifyName, _authorization);
		}
 	}
}