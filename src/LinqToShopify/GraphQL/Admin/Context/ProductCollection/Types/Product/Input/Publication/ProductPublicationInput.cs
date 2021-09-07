using System;

namespace LinqToShopify.GraphQL.Admin.Context.ProductCollection.Types.Product.Input.Publication
{
	/// <summary>
	/// Specifies a publication to which a product will be published.
	/// </summary>
	public class ProductPublicationInput
	{
		/// <summary>
		/// ID of the channel. This argument is deprecated: Use publicationId instead.
		/// </summary>
		public string ChannelId { get; set; }
		
		/// <summary>
		/// ID of the publication.
		/// </summary>
		public string PublicationId { get; set; }
		
		/// <summary>
		/// The date and time that the product was (or will be) published.
		/// </summary>
		public DateTime PublishDate { get; set; }
	}
}