using System.Collections.Generic;
using LinqToGraphQL.Attributes;
using LinqToShopify.GraphQL.Admin.Context.Common.Types.Mutation.Error;
using LinqToShopify.GraphQL.Admin.Context.Global.Mutation.Result;

namespace LinqToShopify.GraphQL.Admin.Context.Common.Types.Mutation.Result
{
	public class UserMutationResult: IMutationResult<UserError>
	{
		/// <summary>
		/// The list of errors that occurred from executing the mutation.
		/// </summary>
		[GraphName("userErrors")]
		public List<UserError> UserErrors { get; set; }
	}
}