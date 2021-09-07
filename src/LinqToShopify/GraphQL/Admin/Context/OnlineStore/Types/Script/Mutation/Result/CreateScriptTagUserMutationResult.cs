using LinqToGraphQL.Attributes;
using LinqToShopify.GraphQL.Admin.Context.Common.Types.Mutation.Result;

namespace LinqToShopify.GraphQL.Admin.Context.OnlineStore.Types.Script.Mutation.Result
{
	public class CreateScriptTagUserMutationResult : UserMutationResult
	{
		/// <summary>
		/// The script tag that was created.
		/// </summary>
		[GraphName("scriptTag")]
		public ScriptTag ScriptTag { get; set; }
	}
}