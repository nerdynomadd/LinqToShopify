using System.Collections.Generic;
using LinqToGraphQL.Attributes;

namespace LinqToShopify.GraphQL.Admin.Context.ProductCollection.Types.Product.Input.Publication
{
	/// <summary>
	/// Specifies a product to publish and the channels to publish it to.
	/// </summary>
	public class ProductPublishInput
	{
		/// <summary>
		/// The product to create or update publications for.
		/// </summary>
		[GraphName("id")]
		public string Id { get; set; }
		
		/// <summary>
		/// The publication that the product is published to.
		/// </summary>
		[GraphName("productPublications")]
		public List<ProductPublicationInput> ProductPublications { get; set; }
	}
}