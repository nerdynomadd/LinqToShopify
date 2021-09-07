using LinqToGraphQL.Attributes;
using LinqToGraphQL.Attributes.Method;
using LinqToShopify.GraphQL.Admin.Context.Common.Types.CurrencyCode;
using LinqToShopify.GraphQL.Admin.Context.Global.Node;
using LinqToShopify.GraphQL.Admin.Context.ProductCollection.Connections;
using LinqToShopify.GraphQL.Admin.Context.ProductCollection.Types.PriceList.Enum;

namespace LinqToShopify.GraphQL.Admin.Context.ProductCollection.Types.PriceList
{
	/// <summary>
	/// Represents a price list, including information about related prices and eligibility rules. You can use price lists to specify either fixed prices or adjusted relative prices that override initial product variant prices. Price lists are applied to customers using context rules, which determine price list eligibility.
	/// </summary>
	public class PriceList : Node
	{
		private PriceListConnection _prices;

		/// <summary>
		/// A list of prices associated with the price list.
		/// </summary>
		/// <param name="before">Returns the elements that come before the specified cursor.</param>
		/// <param name="first">Returns up to the first n elements from the list.</param>
		/// <param name="last">Returns up to the last n elements from the list.</param>
		/// <param name="originType">The origin of this price, either fixed (defined on the price list) or relative (calculated using an adjustment via a price list parent configuration).</param>
		/// <param name="reverse">Reverse the order of the underlying list.</param>
		[GraphName("prices")]
		[GraphBackingField(nameof(_prices))]
		public PriceListConnection Prices(string after = null,
			string before = null,
			int? first = null,
			int? last = null,
			PriceListPriceOriginType? originType = null,
			bool reverse = false) => _prices;

		/// <summary>
		/// A set of facts about the customer, used to determine price list eligibility.
		/// </summary>
		[GraphName("contextRule")]
		public PriceListContextRule ContextRule { get; set; }
		
		/// <summary>
		/// The currency for fixed prices associated with this price list.
		/// </summary>
		[GraphName("currency")]
		public CurrencyCode Currency { get; set; }
		
		/// <summary>
		/// The unique name of the price list, used as a human-readable identifier.
		/// </summary>
		[GraphName("name")]
		public string Name { get; set; }
		
		/// <summary>
		/// Relative adjustments to other prices.
		/// </summary>
		[GraphName("parent")]
		public PriceListParent Parent { get; set; }
	}
}