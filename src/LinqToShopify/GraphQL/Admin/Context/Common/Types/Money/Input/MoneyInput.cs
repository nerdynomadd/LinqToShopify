using LinqToGraphQL.Attributes;

namespace LinqToShopify.GraphQL.Admin.Context.Common.Types.Money.Input
{
	public class MoneyInput
	{
		[GraphName("currencyCode")]
		public CurrencyCode.CurrencyCode CurrencyCode { get; set; }
		
		[GraphName("amount")]
		public decimal Amount { get; set; }
	}
}