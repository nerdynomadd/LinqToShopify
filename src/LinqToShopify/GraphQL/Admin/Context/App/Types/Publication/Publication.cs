using LinqToGraphQL.Attributes;
using LinqToGraphQL.Attributes.Method;
using LinqToShopify.GraphQL.Admin.Context.Common.Types.Id;
using LinqToShopify.GraphQL.Admin.Context.Global.Node;
using LinqToShopify.GraphQL.Admin.Context.ProductCollection.Connections;
using LinqToShopify.GraphQL.Admin.Context.ProductCollection.Global.Connection;

namespace LinqToShopify.GraphQL.Admin.Context.App.Types.Publication
{
	/// <summary>
	/// A publication is a group of products and collections that is published to an app.
	/// </summary>
	public class Publication : Node
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
		/// The app associated with the publication.
		/// </summary>
		[GraphName("app")]
		public App.App App { get; set; }

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
		/// Name of the publication.
		/// </summary>
		public string Name { get; set; }
		
		/// <summary>
		/// Whether or not this publication supports future publishing.
		/// </summary>
		public bool SupportsFuturePublishing { get; set; }

	}
}