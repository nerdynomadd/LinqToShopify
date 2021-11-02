using LinqToGraphQL.Attributes;
using LinqToShopify.GraphQL.Admin.Context.Common.Types.Mutation.Result;

namespace LinqToShopify.GraphQL.Admin.Context.Metafield.Types.Mutation.Result
{
	public class DeleteMetafieldUserMutationResult : UserMutationResult
	{
		/// <summary>
		/// The ID of the deleted metafield.
		/// </summary>
		[GraphName("deletedId")]
		public string DeletedId { get; set; }
	}
}