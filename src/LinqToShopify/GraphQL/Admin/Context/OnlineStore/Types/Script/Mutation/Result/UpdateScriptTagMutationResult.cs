using LinqToGraphQL.Attributes;

namespace LinqToShopify.GraphQL.Admin.Context.OnlineStore.Types.Script.Mutation.Result
{
	public class UpdateScriptTagMutationResult
	{
		/// <summary>
		/// The script tag that was created.
		/// </summary>
		[GraphName("scriptTag")]
		public ScriptTag ScriptTag { get; set; }
	}
}