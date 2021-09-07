using LinqToGraphQL.Attributes;
using LinqToShopify.GraphQL.Admin.Context.Common.Types.Mutation.Result;

namespace LinqToShopify.GraphQL.Admin.Context.Translation.Types.Locale.Mutation.Result
{
	public class DisableShopLocaleUserMutationResult : UserMutationResult
	{
		
		/// <summary>
		/// The locale identifier that was disabled.
		/// </summary>
		[GraphName("locale")]
		public string Locale { get; set; }
		
	}
}