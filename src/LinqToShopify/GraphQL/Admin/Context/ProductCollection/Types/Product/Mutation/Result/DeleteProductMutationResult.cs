using LinqToGraphQL.Attributes;
using LinqToShopify.GraphQL.Admin.Context.Common.Types.Mutation.Result;
using LinqToShopify.GraphQL.Admin.Context.Store.Types.Shop;

namespace LinqToShopify.GraphQL.Admin.Context.ProductCollection.Types.Product.Mutation.Result
{
	public class DeleteProductMutationResult : UserMutationResult
	{
		/// <summary>
		/// The ID of the deleted product.
		/// </summary>
		[GraphName("deletedProductId")]
		public string DeletedProductId { get; set; }
		
		/// <summary>
		/// The shop associated with the product.
		/// </summary>
		[GraphName("shop")]
		public Shop Shop { get; set; }
	}
}