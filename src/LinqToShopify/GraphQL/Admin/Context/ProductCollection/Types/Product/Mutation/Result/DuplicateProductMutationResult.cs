using LinqToGraphQL.Attributes;
using LinqToShopify.GraphQL.Admin.Context.Common.Types.Job;
using LinqToShopify.GraphQL.Admin.Context.Common.Types.Mutation.Result;
using LinqToShopify.GraphQL.Admin.Context.Store.Types.Shop;

namespace LinqToShopify.GraphQL.Admin.Context.ProductCollection.Types.Product.Mutation.Result
{
	public class DuplicateProductMutationResult : UserMutationResult
	{
		/// <summary>
		/// The asynchronous job duplicating the product images.
		/// </summary>
		[GraphName("imageJob")]
		public Job ImageJob { get; set; }
		
		/// <summary>
		/// The duplicated product.
		/// </summary>
		[GraphName("newProduct")]
		public Product NewProduct { get; set; }
		
		/// <summary>
		/// The user's shop.
		/// </summary>
		[GraphName("shop")]
		public Shop Shop { get; set; }
	}
}