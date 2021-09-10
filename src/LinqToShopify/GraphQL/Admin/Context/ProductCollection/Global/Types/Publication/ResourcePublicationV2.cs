using System;
using LinqToGraphQL.Attributes;

namespace LinqToShopify.GraphQL.Admin.Context.ProductCollection.Global.Types.Publication
{
	/// <summary>
	/// A resource publication represents that a resource either has been published or will be published to a publication.
	/// </summary>
	public class ResourcePublicationV2
	{
		/// <summary>
		/// Whether the resource publication is published. Also returns true if the resource publication is scheduled to be published. If false, then the resource publication is neither published nor scheduled to be published.
		/// </summary>
		[GraphName("isPublished")]
		public bool IsPublished { get; set; }
		
		/// <summary>
		/// The publication the resource publication is published to.
		/// </summary>
		[GraphName("publication")]
		public App.Types.Publication.Publication Publication { get; set; }
		
		/// <summary>
		/// The date that the resource publication was or is going to be published to the publication.
		/// </summary>
		[GraphName("publishDate")]
		public DateTime PublishDate { get; set; }
		
		/// <summary>
		/// The resource published to the publication.
		/// </summary>
		[GraphName("publishable")]
		public Publishable Publishable { get; set; }
	}
}