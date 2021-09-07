using LinqToGraphQL.Attributes;

namespace LinqToShopify.GraphQL.Admin.Context.Translation.Types.Locale.Mutation.Result
{
	public class EnableShopLocaleMutationResult
	{
		/// <summary>
		/// The locale identifier that was disabled.
		/// </summary>
		[GraphName("locale")]
		public string Locale { get; set; }
	}
}