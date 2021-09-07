using LinqToGraphQL.Attributes;
using LinqToShopify.GraphQL.Admin.Context.Common.Types.CurrencyCode;

namespace LinqToShopify.GraphQL.Admin.Context.ProductCollection.Types.PriceList.Input
{
	public class PriceListUpdateInput
	{
		/// <summary>
		/// A set of facts about buyer context used to determine price list eligibility.
		/// </summary>
		[GraphName("contextRule")]
		public PriceListContextRuleInput ContextRule { get; set; }
		
		/// <summary>
		/// The three-letter code for fixed prices associated with this price list.
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
		public PriceListParentUpdateInput Parent { get; set; }
	}
}