using System.Collections.Generic;
using LinqToGraphQL.Attributes;
using LinqToShopify.GraphQL.Admin.Context.Common.Types.Mutation.Result;

namespace LinqToShopify.GraphQL.Admin.Context.Translation.Types.Translation.Mutation.Result
{
	public class RegisterTranslationsUserMutationResult : UserMutationResult
	{
		[GraphName("translations")]
		public List<Translation> Translations { get; set; }
	}
}