using LinqToGraphQL.Attributes;
using LinqToShopify.GraphQL.Admin.Context.Common.Types.Job;
using LinqToShopify.GraphQL.Admin.Context.Common.Types.Mutation.Result;

namespace LinqToShopify.GraphQL.Admin.Context.ProductCollection.Types.Product.Mutation.Result.Image
{
	public class ReorderProductImagesMutationResult : UserMutationResult
	{
		
		/// <summary>
		/// The asynchronous job reordering the images.
		/// </summary>
		[GraphName("job")]
		public Job Job { get; set; }
		
	}
}