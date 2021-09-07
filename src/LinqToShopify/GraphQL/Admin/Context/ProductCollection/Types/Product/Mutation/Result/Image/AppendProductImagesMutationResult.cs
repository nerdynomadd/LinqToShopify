using System.Collections.Generic;
using LinqToGraphQL.Attributes;
using LinqToGraphQL.Attributes.Method;
using LinqToShopify.GraphQL.Admin.Context.Common.Types.Image.Query.Input;
using LinqToShopify.GraphQL.Admin.Context.Common.Types.Mutation.Result;

namespace LinqToShopify.GraphQL.Admin.Context.ProductCollection.Types.Product.Mutation.Result.Image
{
	public class AppendProductImagesMutationResult : UserMutationResult
	{

		private List<Common.Types.Image.Image> _newImages;
		
		[GraphName("newImages")]
		[GraphBackingField(nameof(_newImages))]
		public List<Common.Types.Image.Image> NewImages(CropRegion crop, int maxHeight, int maxWidth, int scale) => _newImages;

		[GraphName("product")]
		public Product Product { get; set; }
		
	}
}