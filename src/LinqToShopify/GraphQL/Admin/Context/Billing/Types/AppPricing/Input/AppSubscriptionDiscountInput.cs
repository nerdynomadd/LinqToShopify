using LinqToGraphQL.Attributes;
using LinqToShopify.GraphQL.Admin.Context.Billing.Types.AppSubscriptionDiscountValue.Input;

namespace LinqToShopify.GraphQL.Admin.Context.Billing.Types.AppSubscriptionDiscount.Input
{
	public class AppSubscriptionDiscountInput
	{
		[GraphName("durationLimitInIntervals")]
		public int DurationLimitInIntervals { get; set; }	

		[GraphName("value")]
		public AppSubscriptionDiscountValueInput Value { get; set; }
	}
}