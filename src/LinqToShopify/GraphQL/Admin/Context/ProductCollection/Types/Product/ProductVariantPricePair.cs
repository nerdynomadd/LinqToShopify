using LinqToGraphQL.Attributes;
using LinqToShopify.GraphQL.Admin.Context.Common.Types.MoneyV2;

namespace LinqToShopify.GraphQL.Admin.Context.ProductCollection.Types.Product
{
	/// <summary>
	/// The compare-at price and price of a variant sharing a currency.
	/// </summary>
	public class ProductVariantPricePair
	{
		/// <summary>
		/// The compare-at price of the variant with associated currency.
		/// </summary>
		[GraphName("compareAtPrice")]
		public MoneyV2 CompareAtPrice { get; set; }
		
		/// <summary>
		/// The price of the variant with associated currency.
		/// </summary>
		[GraphName("price")]
		public MoneyV2 Price { get; set; } 
		
	}
}