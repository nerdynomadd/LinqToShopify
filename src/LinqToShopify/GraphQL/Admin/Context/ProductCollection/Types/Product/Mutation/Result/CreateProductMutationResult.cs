using LinqToGraphQL.Attributes;
using LinqToShopify.GraphQL.Admin.Context.Common.Types.Mutation.Result;
using LinqToShopify.GraphQL.Admin.Context.Store.Types.Shop;

namespace LinqToShopify.GraphQL.Admin.Context.ProductCollection.Types.Product.Mutation.Result
{
	public class CreateProductMutationResult : UserMutationResult
	{
		[GraphName("shop")]
		public Product Product { get; set; }
		
		[GraphName("shop")]
		public Shop Shop { get; set; }
	}
}