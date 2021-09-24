using LinqToGraphQL.Attributes;

namespace LinqToShopify.GraphQL.Admin.Context.Common.Types.MoneyV2
{
	public class MoneyV2
	{
		[GraphName("amount")]
		public decimal Amount { get; set; }
		
		[GraphName("currencyCode")]
		public CurrencyCode.CurrencyCode CurrencyCode { get; set; }
	}
}