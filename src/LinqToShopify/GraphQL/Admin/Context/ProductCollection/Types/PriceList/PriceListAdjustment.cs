using LinqToGraphQL.Attributes;
using LinqToShopify.GraphQL.Admin.Context.ProductCollection.Types.PriceList.Enum;

namespace LinqToShopify.GraphQL.Admin.Context.ProductCollection.Types.PriceList
{
	/// <summary>
	/// Represents the type and value of price list adjustments.
	/// </summary>
	public class PriceListAdjustment
	{
		/// <summary>
		/// The type of price adjustment, such as percentage increase or decrease.
		/// </summary>
		[GraphName("type")]
		public PriceListAdjustmentType Type { get; set; }
		
		/// <summary>
		/// The value of price adjustment, where positive numbers reduce the prices and negative numbers increase them.
		/// </summary>
		[GraphName("value")]
		public float Value { get; set; }
	}
}