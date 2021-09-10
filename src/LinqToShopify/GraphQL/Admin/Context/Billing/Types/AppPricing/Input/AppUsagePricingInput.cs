using LinqToGraphQL.Attributes;
using LinqToShopify.GraphQL.Admin.Context.Billing.Types.AppPricing.Enum;
using LinqToShopify.GraphQL.Admin.Context.Common.Types.Money.Input;

namespace LinqToShopify.GraphQL.Admin.Context.Billing.Types.AppPricing.Input
{
	/// <summary>
	/// Allows an app to charge per billing interval.
	/// </summary>
	public class AppUsagePricingInput
	{
		/// <summary>
		/// The limit a customer can be charged for usage based pricing.
		/// </summary>
		[GraphName("cappedAmount")]
		public MoneyInput CappedAmount { get; set; }
		
		/// <summary>
		/// The terms and conditions for app usage.
		/// </summary>
		[GraphName("terms")]
		public string Terms { get; set; }
	}
}