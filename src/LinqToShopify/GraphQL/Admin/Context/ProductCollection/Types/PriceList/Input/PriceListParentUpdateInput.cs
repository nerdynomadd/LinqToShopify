using LinqToGraphQL.Attributes;

namespace LinqToShopify.GraphQL.Admin.Context.ProductCollection.Types.PriceList.Input
{
	/// <summary>
	/// Relative adjustments to other prices.
	/// </summary>
	public class PriceListParentUpdateInput
	{
		/// <summary>
		/// Provides the fields and values to use when updating a price list parent adjustment.
		/// </summary>
		[GraphName("adjustment")]
		public PriceListAdjustmentInput Adjustment { get; set; }
	}
}