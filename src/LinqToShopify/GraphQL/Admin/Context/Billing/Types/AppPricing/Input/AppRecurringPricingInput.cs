using LinqToGraphQL.Attributes;
using LinqToShopify.GraphQL.Admin.Context.Billing.Types.AppPricing.Enum;
using LinqToShopify.GraphQL.Admin.Context.Common.Types.Money.Input;

namespace LinqToShopify.GraphQL.Admin.Context.Billing.Types.AppPricing.Input
{
	/// <summary>
	/// Allows an app to charge a store for usage.
	/// </summary>
	public class AppRecurringPricingInput
	{
		/// <summary>
		/// The billing frequency for the app.
		/// </summary>
		[GraphName("interval")]
		public AppPricingInterval Interval { get; set; }
		
		/// <summary>
		/// The amount to be charged to the store every billing interval. The only permitted currency code is USD.
		/// </summary>
		[GraphName("price")]
		public MoneyInput Price { get; set; }
	}
}