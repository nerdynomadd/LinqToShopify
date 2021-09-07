using LinqToGraphQL.Attributes;
using LinqToShopify.GraphQL.Admin.Context.Common.Types.Mutation.Result;

namespace LinqToShopify.GraphQL.Admin.Context.OnlineStore.Types.Script.Mutation.Result
{
	public class DeleteScriptTagUserMutationResult : UserMutationResult
	{
		/// <summary>
		/// The ID of the deleted script tag.
		/// </summary>
		[GraphName("deletedScriptTagId")]
		public string DeletedScriptTagId { get; set; }
	}
}