using LinqToGraphQL.Attributes;
using LinqToShopify.GraphQL.Admin.Context.Common.Types.Mutation.Result;

namespace LinqToShopify.GraphQL.Admin.Context.Billing.Types.AppSubscription.Mutation.Result
{
	public class UpdateSubscriptionLineItemUserMutationResult : UserMutationResult
	{
		/// <summary>
		/// The updated app subscription.
		/// </summary>
		[GraphName("appSubscription")]
		public AppSubscription AppSubscription { get; set; }
		
		/// <summary>
		/// The URL where the merchant approves or declines the updated app subscription line item.
		/// </summary>
		[GraphName("confirmationUrl")]
		public string ConfirmationUrl { get; set; }
	}
}