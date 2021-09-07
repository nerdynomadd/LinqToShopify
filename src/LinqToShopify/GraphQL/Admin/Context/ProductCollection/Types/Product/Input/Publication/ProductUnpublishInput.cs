using System.Collections.Generic;
using LinqToGraphQL.Attributes;

namespace LinqToShopify.GraphQL.Admin.Context.ProductCollection.Types.Product.Input.Publication
{
	/// <summary>
	/// Specifies a product to unpublish from a channel and the sales channels to unpublish it from.
	/// </summary>
	public class ProductUnpublishInput
	{
		/// <summary>
		/// The ID of the product to create or update publications for.
		/// </summary>
		[GraphName("id")]
		public string Id { get; set; }
		
		/// <summary>
		/// The channels to unpublish the product from.
		/// </summary>
		[GraphName("productPublications")]
		public List<ProductPublicationInput> ProductPublications { get; set; }
	}
}