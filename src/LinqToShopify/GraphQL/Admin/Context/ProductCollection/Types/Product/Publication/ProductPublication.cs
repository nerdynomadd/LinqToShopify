using System;
using LinqToGraphQL.Attributes;

namespace LinqToShopify.GraphQL.Admin.Context.ProductCollection.Types.Product.Publication
{
	/// <summary>
	/// Represents the channels where a product is published.
	/// </summary>
	public class ProductPublication
	{
		/// <summary>
		/// The channel where the product was or is published.
		/// </summary>
		[GraphName("channel")]
		public Channel.Channel Channel { get; set; }
		
		/// <summary>
		/// Whether the publication is published or not.
		/// </summary>
		[GraphName("isPublished")]
		public bool IsPublished { get; set; }
		
		/// <summary>
		/// The product that was or is going to be published on the channel.
		/// </summary>
		[GraphName("product")]
		public Product Product { get; set; }
		
		/// <summary>
		/// The date that the product was or is going to be published on the channel.
		/// An auto-generated type for paginating through multiple ProductPublications.
		/// </summary>
		[GraphName("publishDate")]
		public DateTime PublishDate { get; set; }
	}
}