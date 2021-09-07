using LinqToGraphQL.Attributes;

namespace LinqToShopify.GraphQL.Admin.Context.ProductCollection.Types.Collection.Input.Publication
{
	/// <summary>
	/// Specifies the publications to which a collection will be published.
	/// </summary>
	public class CollectionPublicationInput
	{
		/// <summary>
		/// This argument is deprecated: Use publicationId instead.
		/// </summary>
		[GraphName("channelHandle")]
		public string ChannelHandle { get; set; }

		/// <summary>
		/// The ID of the publication.
		/// </summary>
		[GraphName("publicationId")]
		public string PublicationId { get; set; }
	}
}