using LinqToGraphQL.Attributes;
using LinqToShopify.GraphQL.Admin.Context.Common.Types.Mutation.Result;

namespace LinqToShopify.GraphQL.Admin.Context.OnlineStore.Types.Url.Mutation.Result
{
	public class SubmitUrlRedirectImportMutationResult : UserMutationResult
	{
		/// <summary>
		/// The created URL redirect import.
		/// </summary>
		[GraphName("urlRedirectImport")]
		public UrlRedirectImport UrlRedirectImport { get; set; }
	}
}