using LinqToGraphQL.Attributes;
using LinqToShopify.GraphQL.Admin.Context.Common.Types.Mutation.Result;

namespace LinqToShopify.GraphQL.Admin.Context.ProductCollection.Types.Product.Mutation.Result
{
	public class UpdateProductMutationResult : UserMutationResult
	{
		
		/// <summary>
		/// The updated product.
		/// </summary>
		[GraphName("product")]
		public Product Product { get; set; }
		
	}
}