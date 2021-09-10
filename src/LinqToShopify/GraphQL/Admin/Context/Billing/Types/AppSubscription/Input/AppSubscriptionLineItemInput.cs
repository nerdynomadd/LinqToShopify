using LinqToGraphQL.Attributes;
using LinqToShopify.GraphQL.Admin.Context.Billing.Types.Global.AppPlan.Input;

namespace LinqToShopify.GraphQL.Admin.Context.Billing.Types.AppSubscription.Input
{
	public class AppSubscriptionLineItemInput
	{
		[GraphName("plan")]
		public AppPlanInput Plan { get; set; }
	}
}