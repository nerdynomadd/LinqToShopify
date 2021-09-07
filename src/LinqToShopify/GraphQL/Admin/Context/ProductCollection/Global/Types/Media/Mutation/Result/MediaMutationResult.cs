using System.Collections.Generic;
using LinqToGraphQL.Attributes;
using LinqToShopify.GraphQL.Admin.Context.Global.Mutation.Result;
using LinqToShopify.GraphQL.Admin.Context.ProductCollection.Global.Types.Media.Mutation.Error;

namespace LinqToShopify.GraphQL.Admin.Context.ProductCollection.Global.Types.Media.Mutation.Result
{
	public class MediaMutationResult: IMutationResult<MediaUserError>
	{
		/// <summary>
		/// The list of errors that occurred from executing the mutation.
		/// </summary>
		[GraphName("mediaUserErrors")]
		public List<MediaUserError> MediaUserErrors { get; set; }
	}
}