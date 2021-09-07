using System;

namespace LinqToShopify.GraphQL.Admin.Context.ProductCollection.Types.Collection.Publication
{
	/// <summary>
	/// Represents the publications where a collection is published.
	/// </summary>
	public class CollectionPublication
	{
		/// <summary>
		/// The collection to be published on the publication.
		/// </summary>
		public Collection Collection { get; set; }
		
		/// <summary>
		/// Whether the publication is published or not.
		/// </summary>
		public bool IsPublished { get; set; }
		
		/// <summary>
		/// The publication where the collection will be published.
		/// </summary>
		public App.Types.Publication.Publication Publication { get; set; }
		
		/// <summary>
		/// The date that the publication was or is going to be published.
		/// </summary>
		public DateTime PublishDate { get; set; }
	}
}