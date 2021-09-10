using LinqToGraphQL.Attributes;
using LinqToShopify.GraphQL.Admin.Context.Common.Types.Mutation.Result;

namespace LinqToShopify.GraphQL.Admin.Context.Billing.Types.AppPurchase.OneTime.Mutation.Result
{
	public class AppPurchaseOneTimeCreateUserMutationResult : UserMutationResult
	{
		[GraphName("appPurchaseOneTime")]
		public AppPurchaseOneTime AppPurchaseOneTime { get; set; }
		
		[GraphName("confirmationUrl")]
		public string ConfirmationUrl { get; set; }
	}
}