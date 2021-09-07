using LinqToGraphQL.Attributes;
using LinqToShopify.GraphQL.Admin.Context.Billing.Types.AppPricing;

namespace LinqToShopify.GraphQL.Admin.Context.Billing.Types.Global.AppPlan
{
	public class AppPlanV2
	{
		[GraphName("pricingDetails")]
		[GraphUnionTypeProperty(typeof(AppUsagePricing), typeof(AppRecurringPricing))]
		public object PricingDetails { get; set; }
	}
}