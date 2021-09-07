using System;
using LinqToGraphQL.Attributes;
using LinqToShopify.GraphQL.Admin.Context.App.Types.Publication;

namespace LinqToShopify.GraphQL.Admin.Context.ProductCollection.Global.Types.ResourcePublication
{
	public class ResourcePublication
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
		public Publishable.Publishable Publishable { get; set; }
	}
}