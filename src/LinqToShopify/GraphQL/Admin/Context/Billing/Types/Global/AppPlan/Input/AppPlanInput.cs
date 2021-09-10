using LinqToGraphQL.Attributes;
using LinqToShopify.GraphQL.Admin.Context.Billing.Types.AppPricing.Input;

namespace LinqToShopify.GraphQL.Admin.Context.Billing.Types.Global.AppPlan.Input
{
	/// <summary>
	/// Defines the pricing model for the app subscription.
	/// </summary>
	public class AppPlanInput
	{
		/// <summary>
		/// Recurring based billing pricing details.
		/// </summary>
		[GraphName("appRecurringPricingDetails")]
		public AppRecurringPricingInput AppRecurringPricingDetails { get; set; }
		
		/// <summary>
		/// Usage based billing pricing details.
		/// </summary>
		/// <returns></returns>
		[GraphName("appUsagePricingDetails")]
		public AppUsagePricingInput AppUsagePricingDetails { get; set; }
	}
}