using System.Collections.Generic;
using LinqToGraphQL.Attributes;
using LinqToShopify.GraphQL.Admin.Context.Common.Types.Image.Mutation.Input;

namespace LinqToShopify.GraphQL.Admin.Context.ProductCollection.Types.Product.Input.Image
{
	public class ProductAppendImagesInput
	{
		/// <summary>
		/// The ID of the product.
		/// </summary>
		[GraphName("id")]
		public int Id { get; set; }
		
		/// <summary>
		/// The images to be appended to the product.
		/// </summary>
		[GraphName("images")]
		public List<ImageInput> Images { get; set; }
	}
}