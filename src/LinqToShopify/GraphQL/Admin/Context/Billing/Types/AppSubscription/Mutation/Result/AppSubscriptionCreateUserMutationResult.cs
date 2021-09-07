using LinqToGraphQL.Attributes;
using LinqToShopify.GraphQL.Admin.Context.Common.Types.Mutation.Result;

namespace LinqToShopify.GraphQL.Admin.Context.Billing.Types.AppSubscription.Mutation.Result
{
	public class AppSubscriptionCreateUserMutationResult : UserMutationResult
	{
		[GraphName("appSubscription")]
		public AppSubscription AppSubscription { get; set; }
		
		[GraphName("confirmationUrl")]
		public string ConfirmationUrl { get; set; }
	}
}