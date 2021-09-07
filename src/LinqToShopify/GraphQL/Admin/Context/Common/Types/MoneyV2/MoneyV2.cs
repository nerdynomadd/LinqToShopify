using Newtonsoft.Json;

namespace LinqToShopify.GraphQL.Admin.Context.Common.Types.MoneyV2
{
	public class MoneyV2
	{
		[JsonProperty("amount")]
		public decimal Amount { get; set; }
		
		[JsonProperty("currencyCode")]
		public CurrencyCode.CurrencyCode CurrencyCode { get; set; }
	}
}