using LinqToGraphQL.Attributes;
using LinqToShopify.GraphQL.Admin.Context.Billing.Types.AppPricing.Enum;
using LinqToShopify.GraphQL.Admin.Context.Common.Types.MoneyV2;

namespace LinqToShopify.GraphQL.Admin.Context.Billing.Types.AppPricing
{
	public class AppRecurringPricing
	{
		[GraphName("price")]
		public MoneyV2 BalanceUsed { get; set; }
		
		[GraphName("interval")]
		public AppPricingInterval Interval { get; set; }
	}
}