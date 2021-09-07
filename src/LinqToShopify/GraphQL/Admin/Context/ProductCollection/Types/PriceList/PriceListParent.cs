using System.Collections.Generic;
using LinqToShopify.GraphQL.Admin.Context.ProductCollection.Types.PriceList.Enum;

namespace LinqToShopify.GraphQL.Admin.Context.ProductCollection.Types.PriceList
{
	/// <summary>
	/// Represents relative adjustments from one price list to other prices. You can use a PriceListParent to specify an adjusted relative price using a percentage-based adjustment. Adjusted prices work in conjunction with exchange rules and rounding.
	/// </summary>
	public class PriceListParent
	{
		/// <summary>
		/// A price list adjustment.
		/// </summary>
		public List<PriceListAdjustmentType> Adjustment { get; set; }
	}
}