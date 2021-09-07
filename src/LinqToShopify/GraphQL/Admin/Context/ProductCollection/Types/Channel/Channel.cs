using LinqToGraphQL.Attributes;
using LinqToGraphQL.Attributes.Method;
using LinqToShopify.GraphQL.Admin.Context.Common.Types.Id;
using LinqToShopify.GraphQL.Admin.Context.Global.Node;
using LinqToShopify.GraphQL.Admin.Context.ProductCollection.Connections;
using LinqToShopify.GraphQL.Admin.Context.ProductCollection.Global.Connection;

namespace LinqToShopify.GraphQL.Admin.Context.ProductCollection.Types.Channel
{
	public class Channel : Node
	{
		private ResourcePublicationConnection _collectionPublicationsV3;

		/// <summary>
		/// The collection publications for the list of collections published to the publication.
		/// </summary>
		/// <param name="after">Returns the elements that come after the specified cursor.</param>
		/// <param name="before">Returns the elements that come before the specified cursor.</param>
		/// <param name="first">Returns up to the first n elements from the list.</param>
		/// <param name="last">Returns up to the last n elements from the list.</param>
		/// <param name="reverse">Reverse the order of the underlying list.</param>
		/// <returns></returns>
		[GraphName("collectionPublicationsV3")]
		[GraphBackingField(nameof(_collectionPublicationsV3))]
		public ResourcePublicationConnection CollectionPublicationsV3(string after = default, 
			string before = default, 
			int? first = null, 
			int? last = null, 
			bool reverse = false) => _collectionPublicationsV3;
		
		private CollectionConnection _collections;

		/// <summary>
		/// The list of collections published to the publication.
		/// </summary>
		/// <param name="after">Returns the elements that come after the specified cursor.</param>
		/// <param name="before">Returns the elements that come before the specified cursor.</param>
		/// <param name="first">Returns up to the first n elements from the list.</param>
		/// <param name="last">Returns up to the last n elements from the list.</param>
		/// <param name="reverse">Reverse the order of the underlying list.</param>
		/// <returns></returns>
		[GraphName("collections")]
		public CollectionConnection Collections(string after = default, 
			string before = default, 
			int? first = null, 
			int? last = null, 
			bool reverse = false) => _collections;

		private ResourcePublicationConnection _productPublicationsV3;

		/// <summary>
		/// The collection publications for the list of collections published to the publication.
		/// </summary>
		/// <param name="after">Returns the elements that come after the specified cursor.</param>
		/// <param name="before">Returns the elements that come before the specified cursor.</param>
		/// <param name="first">Returns up to the first n elements from the list.</param>
		/// <param name="last">Returns up to the last n elements from the list.</param>
		/// <param name="reverse">Reverse the order of the underlying list.</param>
		/// <returns></returns>
		[GraphName("productPublicationsV3")]
		[GraphBackingField(nameof(_productPublicationsV3))]
		public ResourcePublicationConnection ProductPublicationsV3(string after = default, 
			string before = default, 
			int? first = null, 
			int? last = null, 
			bool reverse = false) => _productPublicationsV3;
		
		private ProductConnection _products;

		/// <summary>
		/// The list of products published to the publication.
		/// </summary>
		/// <param name="after">Returns the elements that come after the specified cursor.</param>
		/// <param name="before">Returns the elements that come before the specified cursor.</param>
		/// <param name="first">Returns up to the first n elements from the list.</param>
		/// <param name="last">Returns up to the last n elements from the list.</param>
		/// <param name="reverse">Reverse the order of the underlying list.</param>
		/// <returns></returns>
		[GraphName("products")]
		public ProductConnection Products(string after = default, 
			string before = default, 
			int? first = null, 
			int? last = null, 
			bool reverse = false) => _products;
		
		/// <summary>
		/// Underlying app used by the channel.
		/// </summary>
		[GraphName("app")]
		public App.Types.App.App App { get; set; }
		
		private bool _hasCollection;

		/// <summary>
		/// Whether the collection is available to the publication.
		/// </summary>
		/// <param name="id">Collection ID to check.</param>
		/// <returns></returns>
		[GraphName("hasCollection")]
		[GraphBackingField(nameof(_hasCollection))]
		public bool HasCollection([GraphNonNullableParameter] [GraphParameterType(typeof(ID))] string id) => _hasCollection;
		
		/// <summary>
		/// Name of the channel.
		/// </summary>
		[GraphName("name")]
		public string Name { get; set; }
		
		/// <summary>
		/// Whether or not this channel supports future publishing.
		/// </summary>
		[GraphName("supportsFuturePublishing")]
		public bool SupportsFuturePublishing { get; set; }
	}
}