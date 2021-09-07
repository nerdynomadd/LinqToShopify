using System.Collections.Generic;
using LinqToGraphQL.Attributes;

namespace LinqToShopify.GraphQL.Admin.Context.ProductCollection.Types.Collection.Input.Publication
{
	/// <summary>
	/// Specifies a collection to publish and the sales channels to publish it to.
	/// </summary>
	public class CollectionPublishInput
	{
		/// <summary>
		/// The channels where the collection will be published.
		/// </summary>
		[GraphName("collectionPublications")]
		public List<CollectionPublicationInput> CollectionPublications { get; set; }
		
		/// <summary>
		/// The collection to create or update publications for.
		/// </summary>
		[GraphName("id")]
		public string Id { get; set; }
	}
}