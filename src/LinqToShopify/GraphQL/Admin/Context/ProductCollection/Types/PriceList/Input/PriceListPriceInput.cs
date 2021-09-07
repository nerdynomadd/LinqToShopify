using LinqToGraphQL.Attributes;
using LinqToShopify.GraphQL.Admin.Context.Common.Types.Money.Input;

namespace LinqToShopify.GraphQL.Admin.Context.ProductCollection.Types.PriceList.Input
{
	/// <summary>
	/// Provides the fields and values to use when creating or updating a fixed price list price.
	/// </summary>
	public class PriceListPriceInput
	{
		/// <summary>
		/// The compare-at price of the product variant on this price list.
		/// </summary>
		[GraphName("compareAtPrice")]
		public MoneyInput CompareAtPrice { get; set; }
		
		/// <summary>
		/// The price of the product variant on this price list.
		/// </summary>
		[GraphName("price")]
		public MoneyInput Price { get; set; }
		
		/// <summary>
		/// The product variant ID associated with the price list price.
		/// </summary>
		[GraphName("variantId")]
		public string VariantId { get; set; }
	}
}