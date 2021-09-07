using LinqToGraphQL.Attributes;
using LinqToShopify.GraphQL.Admin.Context.Common.Types.Mutation.Result;

namespace LinqToShopify.GraphQL.Admin.Context.ProductCollection.Types.Product.Mutation.Result.Image
{
	public class UpdateProductImageMutationResult : UserMutationResult
	{
		/// <summary>
		/// Image updated.
		/// </summary>
		[GraphName("image")]
		public Common.Types.Image.Image Image { get; set; }
	}
}