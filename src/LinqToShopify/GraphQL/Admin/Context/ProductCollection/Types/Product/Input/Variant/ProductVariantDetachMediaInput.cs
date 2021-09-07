using System.Collections.Generic;
using LinqToGraphQL.Attributes;

namespace LinqToShopify.GraphQL.Admin.Context.ProductCollection.Types.Product.Input.Variant
{
	/// <summary>
	/// Specifies the input fields required to detach media from a single variant.
	/// </summary>
	public class ProductVariantDetachMediaInput
	{
		/// <summary>
		/// Specifies the media to append to the variant.
		/// </summary>
		[GraphName("mediaIds")]
		public List<string> MediaIds { get; set; }
		
		/// <summary>
		/// Specifies the variant to which media will be appended.
		/// </summary>
		[GraphName("variantId")]
		public string VariantId { get; set; }
	}
}