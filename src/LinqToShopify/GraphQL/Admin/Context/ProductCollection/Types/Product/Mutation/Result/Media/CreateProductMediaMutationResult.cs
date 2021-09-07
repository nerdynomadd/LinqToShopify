using System.Collections.Generic;
using LinqToGraphQL.Attributes;
using LinqToShopify.GraphQL.Admin.Context.Common.Types.Mutation.Result;

namespace LinqToShopify.GraphQL.Admin.Context.ProductCollection.Types.Product.Mutation.Result.Media
{
	public class CreateProductMediaMutationResult : UserMutationResult
	{
		/// <summary>
		/// The newly created media.
		/// </summary>
		[GraphName("media")]
		public List<Global.Types.Media.Media> Media { get; set; }
		
		/// <summary>
		/// The product associated with the media.
		/// </summary>
		[GraphName("product")]
		public Product Product { get; set; }
	}
}