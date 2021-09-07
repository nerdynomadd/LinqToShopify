using System.Collections.Generic;
using LinqToGraphQL.Attributes;
using LinqToShopify.GraphQL.Admin.Context.Common.Connections;
using LinqToShopify.GraphQL.Admin.Context.ProductCollection.Global.Types.Media.Mutation.Result;

namespace LinqToShopify.GraphQL.Admin.Context.ProductCollection.Types.Product.Mutation.Result.Media
{
	public class DeleteProductMediaMutationResult : MediaMutationResult
	{
		/// <summary>
		/// List of media IDs which were deleted.
		/// </summary>
		/// <returns></returns>
		[GraphName("deletedMediaIds")]
		public List<string> DeletedMediaIds { get; set; }
		
		/// <summary>
		/// List of product image IDs which were deleted.
		/// </summary>
		[GraphName("deletedProductImageIds")]
		public List<StringConnection> DeletedProductImageIds { get; set; }
		
		/// <summary>
		/// The product which media was deleted from.
		/// </summary>
		[GraphName("product")]
		public Product Product { get; set; }
	}
}