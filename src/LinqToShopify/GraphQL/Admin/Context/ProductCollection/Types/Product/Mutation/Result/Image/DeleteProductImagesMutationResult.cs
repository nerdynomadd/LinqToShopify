using System.Collections.Generic;
using LinqToGraphQL.Attributes;
using LinqToShopify.GraphQL.Admin.Context.Common.Types.Mutation.Result;

namespace LinqToShopify.GraphQL.Admin.Context.ProductCollection.Types.Product.Mutation.Result.Image
{
	public class DeleteProductImagesMutationResult : UserMutationResult
	{
		/// <summary>
		/// This is an array of IDs of images to delete.
		/// </summary>
		[GraphName("deletedImageIds")]
		public List<string> DeletedImageIds { get; set; }
		
		/// <summary>
		/// This is the product object.
		/// </summary>
		[GraphName("product")]
		public Product Product { get; set; }
	}
}