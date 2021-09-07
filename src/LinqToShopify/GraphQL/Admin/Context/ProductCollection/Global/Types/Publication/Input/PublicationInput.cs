using System;
using LinqToGraphQL.Attributes;

namespace LinqToShopify.GraphQL.Admin.Context.ProductCollection.Global.Types.Publication.Input
{
	public class PublicationInput
	{
		/// <summary>
		/// ID of the publication.
		/// </summary>
		[GraphName("publicationId")]
		public string PublicationId { get; set; }
		
		/// <summary>
		/// The date and time that the resource was published. Setting this to a date in the future will schedule the resource to be published. Only online store channels support future publishing.
		/// </summary>
		[GraphName("publishDate")]
		public DateTime PublishDate { get; set; }
	}
}