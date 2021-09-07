using LinqToGraphQL.Attributes;
using LinqToShopify.GraphQL.Admin.Context.Common.Types.MoneyV2;

namespace LinqToShopify.GraphQL.Admin.Context.ProductCollection.Types.Product.Price
{
	public class ProductPriceRangeV2
	{
		[GraphName("maxVariantPrice")]
		public MoneyV2 MaxVariantPrice { get; set; }
		
		[GraphName("minVariantPrice")]
		public MoneyV2 MinVariantPrice { get; set; }
	}
}