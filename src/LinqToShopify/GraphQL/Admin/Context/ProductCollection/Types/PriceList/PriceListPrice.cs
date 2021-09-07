using LinqToGraphQL.Attributes;
using LinqToShopify.GraphQL.Admin.Context.Common.Types.MoneyV2;
using LinqToShopify.GraphQL.Admin.Context.ProductCollection.Types.PriceList.Enum;
using LinqToShopify.GraphQL.Admin.Context.ProductCollection.Types.Product.Variant;

namespace LinqToShopify.GraphQL.Admin.Context.ProductCollection.Types.PriceList
{
	/// <summary>
	/// Represents a price list, including information about related prices and eligibility rules. You can use price lists to specify either fixed prices or adjusted relative prices that override initial product variant prices. Price lists are applied to customers using context rules, which determine price list eligibility.
	/// </summary>
	public class PriceListPrice
	{
		/// <summary>
		/// The compare-at price of the product variant on this price list.
		/// </summary>
		[GraphName("compareAtPrice")]
		public MoneyV2 CompareAtPrice { get; set; }
		
		/// <summary>
		/// The origin of this price, either fixed (defined on the price list) or relative (calculated using an adjustment via a price list parent configuration).
		/// </summary>
		[GraphName("originType")]
		public PriceListPriceOriginType OriginType { get; set; }
		
		/// <summary>
		/// The price of the product variant on this price list.
		/// </summary>
		[GraphName("price")]
		public MoneyV2 Price { get; set; }
		
		/// <summary>
		/// The product variant associated with this price.
		/// </summary>
		[GraphName("variant")]
		public ProductVariant Variant { get; set; }
	}
}