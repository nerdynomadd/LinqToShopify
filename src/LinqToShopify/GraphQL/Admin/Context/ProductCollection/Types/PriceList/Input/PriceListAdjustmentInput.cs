using LinqToGraphQL.Attributes;
using LinqToShopify.GraphQL.Admin.Context.ProductCollection.Types.PriceList.Enum;

namespace LinqToShopify.GraphQL.Admin.Context.ProductCollection.Types.PriceList.Input
{
	/// <summary>
	/// Provides the fields and values to use when updating a price list parent adjustment.
	/// </summary>
	public class PriceListAdjustmentInput
	{
		/// <summary>
		/// The type of price adjustment, such as percentage increase or decrease.
		/// </summary>
		[GraphName("type")]
		public PriceListAdjustmentType Type { get; set; }
		
		/// <summary>
		/// The value of the price adjustment, where positive numbers reduce the prices and negative numbers increase them.
		/// </summary>
		[GraphName("value")]
		public float Value { get; set; }
	}
}