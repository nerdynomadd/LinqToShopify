using LinqToGraphQL.Attributes;
using LinqToShopify.GraphQL.Admin.Context.Common.Types.Mutation.Result;

namespace LinqToShopify.GraphQL.Admin.Context.Billing.Types.AppSubscription.Mutation.Result
{
	public class AppSubscriptionCancelUserMutationResult : UserMutationResult
	{
		/// <summary>
		/// The cancelled app subscription.
		/// </summary>
		[GraphName("appSubscription")]
		public AppSubscription AppSubscription { get; set; }
	}
}