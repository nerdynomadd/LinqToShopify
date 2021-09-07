using System.Collections.Generic;
using LinqToGraphQL.Context;

namespace LinqToShopify.GraphQL.Admin.Context.ProductCollection
{
	public class PriceListContext : GraphContext
	{
		public PriceListContext(string myShopifyName, string authorization) : base(new Dictionary<string, object>
		{
			["MyShopifyName"] = myShopifyName,
			["Authorization"] = authorization
		})
		{
		}
	}
}