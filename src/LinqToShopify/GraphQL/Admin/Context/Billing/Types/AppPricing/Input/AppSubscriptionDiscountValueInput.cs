using LinqToGraphQL.Attributes;

namespace LinqToShopify.GraphQL.Admin.Context.Billing.Types.AppSubscriptionDiscountValue.Input
{
	public class AppSubscriptionDiscountValueInput
	{
		/// <summary>
		/// The limit a customer can be charged for usage based pricing.
		/// </summary>
		[GraphName("amount")]
		public decimal Amount { get; set; }
		
		/// <summary>
		/// The terms and conditions for app usage.
		/// </summary>
		[GraphName("percentage")]
		public float Percentage { get; set; }
	}
}