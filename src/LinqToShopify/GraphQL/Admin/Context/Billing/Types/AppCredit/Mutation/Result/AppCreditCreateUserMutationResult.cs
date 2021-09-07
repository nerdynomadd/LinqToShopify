using LinqToGraphQL.Attributes;
using LinqToShopify.GraphQL.Admin.Context.Common.Types.Mutation.Result;

namespace LinqToShopify.GraphQL.Admin.Context.Billing.Types.AppCredit.Mutation.Result
{
	public class AppCreditCreateUserMutationResult : UserMutationResult
	{
		[GraphName("appCredit")]
		public AppCredit AppCredit { get; set; }
	}
}