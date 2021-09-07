using System;
using System.Collections.Generic;
using LinqToGraphQL.Attributes;
using LinqToGraphQL.Attributes.Method;
using LinqToShopify.GraphQL.Admin.Context.App.Types.ResourceFeedback;
using LinqToShopify.GraphQL.Admin.Context.Common.Connections;
using LinqToShopify.GraphQL.Admin.Context.Common.Types.Id;
using LinqToShopify.GraphQL.Admin.Context.Metafield.Types;
using LinqToShopify.GraphQL.Admin.Context.Metafield.Types.Interface;
using LinqToShopify.GraphQL.Admin.Context.OnlineStore.Types.Seo;
using LinqToShopify.GraphQL.Admin.Context.ProductCollection.Connections;
using LinqToShopify.GraphQL.Admin.Context.ProductCollection.Global.Types.Publishable;
using LinqToShopify.GraphQL.Admin.Context.ProductCollection.Types.Collection.Enum;
using LinqToShopify.GraphQL.Admin.Context.ProductCollection.Types.Collection.Rule;
using LinqToShopify.GraphQL.Admin.Context.ProductCollection.Types.Product.Enum.Collection;
using LinqToShopify.GraphQL.Admin.Context.Translation.Types.Translation;

namespace LinqToShopify.GraphQL.Admin.Context.ProductCollection.Types.Collection
{
	public class Collection : Publishable, IHasMetafields
	{
		private MetafieldConnection _metafields;

		/// <summary>
		/// List of metafields that belong to the resource.
		/// </summary>
		/// <param name="after">Returns the elements that come after the specified cursor.</param>
		/// <param name="before">Returns the elements that come before the specified cursor.</param>
		/// <param name="first">Returns up to the first n elements from the list.</param>
		/// <param name="last">Returns up to the last n elements from the list.</param>
		/// <param name="namespace">The metafield namespace to filter by.</param>
		/// <param name="reverse">Reverse the order of the underlying list.</param>
		/// <returns></returns>
		[GraphName("metafields")]
		[GraphBackingField(nameof(_metafields))]
		public MetafieldConnection Metafields(string after = default, 
			string before  = default, 
			int? first = null, 
			int? last = null, 
			[GraphName("namespace")] string @namespace = default, 
			bool reverse = default) => _metafields;

		private PrivateMetafieldConnection _privateMetafields;
		
		/// <summary>
		/// List of private metafields that belong to the resource.
		/// </summary>
		/// <param name="after">Returns the elements that come after the specified cursor.</param>
		/// <param name="before">Returns the elements that come before the specified cursor.</param>
		/// <param name="first">Returns up to the first n elements from the list.</param>
		/// <param name="last">Returns up to the last n elements from the list.</param>
		/// <param name="namespace">The metafield namespace to filter by.</param>
		/// <param name="reverse">Reverse the order of the underlying list.</param>
		/// <returns></returns>
		[GraphName("privateMetafields")]
		[GraphBackingField(nameof(_privateMetafields))]
		public PrivateMetafieldConnection PrivateMetafields(string after = default, 
			string before = default, 
			int? first = null, 
			int? last = null, 
			[GraphName("namespace")] string @namespace = default, 
			bool reverse = default) => _privateMetafields;

		private ProductConnection _products;

		/// <summary>
		/// 
		/// </summary>
		/// <param name="after">Returns the elements that come after the specified cursor.</param>
		/// <param name="before">Returns the elements that come before the specified cursor.</param>
		/// <param name="first">Returns up to the first n elements from the list.</param>
		/// <param name="last">Returns up to the last n elements from the list.</param>
		/// <param name="query">This field is only used when the collection is smart. If the collection is custom it returns an error</param>
		/// <param name="reverse">Reverse the order of the underlying list.</param>
		/// <param name="sortKeys">Sort the underlying list by the given key.</param>
		/// <returns></returns>
		[GraphName("products")]
		[GraphBackingField(nameof(_products))]
		public ProductConnection Products(string after = default,
			string before = default,
			int? first = null,
			int? last = null,
			string query = default,
			bool reverse = default,
			ProductCollectionSortKeys sortKeys = default) => _products;
		
		/// <summary>
		/// The stripped description of the collection, in a single line with HTML tags removed.
		/// </summary>
		[GraphName("description")]
		public string Description { get; set; }

		/// <summary>
		/// The description of the collection, complete with HTML formatting.
		/// </summary>
		[GraphName("descriptionHtml")]
		public string DescriptionHtml { get; set; }
		
		/// <summary>
		/// Information about the collection that's provided through resource feedback.
		/// </summary>
		public ResourceFeedback Feedback { get; set; }
		
		/// <summary>
		/// A unique human-friendly string for the collection. Automatically generated from the collection's title.
		/// </summary>
		public string Handle { get; set; }

		private bool _hasProduct;

		/// <summary>
		/// Whether the collection includes a product.
		/// </summary>
		[GraphName("hasProduct")]
		[GraphBackingField(nameof(_hasProduct))]
		public bool HasProduct([GraphNonNullableParameter] [GraphParameterType(typeof(ID))] string id) => _hasProduct;
		
		/// <summary>
		/// The ID of the corresponding resource in the REST Admin API.
		/// </summary>
		[GraphName("legacyResourceId")]
		public UInt64 LegacyResourceId { get; set; }

		private Metafield.Types.Metafield _metafield;

		/// <summary>
		/// Returns a metafield by namespace and key that belongs to the resource.
		/// </summary>
		/// <param name="key">The key for the metafield.</param>
		/// <param name="namespace">The key for the metafield.</param>
		/// <returns></returns>
		[GraphName("metafield")]
		[GraphBackingField(nameof(_metafield))]
		public Metafield.Types.Metafield Metafield([GraphNonNullableParameter] string key,
			[GraphNonNullableParameter] [GraphName("namespace")] string @namespace) => _metafield;
		
		private PrivateMetafield _privateMetafield;

		/// <summary>
		/// Returns a private metafield by namespace and key that belongs to the resource.
		/// </summary>
		/// <param name="key">The key for the metafield.</param>
		/// <param name="namespace">The key for the metafield.</param>
		/// <returns></returns>
		[GraphName("metafield")]
		[GraphBackingField(nameof(_privateMetafield))]
		public PrivateMetafield PrivateMetafield([GraphNonNullableParameter] string key,
			[GraphNonNullableParameter] [GraphName("namespace")] string @namespace) => _privateMetafield;
		
		/// <summary>
		/// The number of products included in the collection.
		/// </summary>
		[GraphName("productsCount")]
		public int ProductsCount { get; set; }

		private int _publicationCount;

		/// <summary>
		/// The number of publications a resource is published on.
		/// </summary>
		/// <param name="onlyPublished">Include only the resource's publications that are published. If false, then return all the resource's publications including future publications.</param>
		/// <returns></returns>
		[GraphName("publicationCount")]
		[GraphBackingField(nameof(_publicationCount))]
		public int PublicationCount(bool onlyPublished = true) => _publicationCount;
		
		/// <summary>
		/// Check to see whether the resource is published to the calling app's publication.
		/// </summary>
		[GraphName("publishedOnCurrentPublication")]
		public bool PublishedOnCurrentPublication { get; set; }

		private bool _publishedOnPublication;

		/// <summary>
		/// Check to see whether the resource is published to a given publication.
		/// </summary>
		/// <param name="publicationId">The ID of the publication to check.</param>
		/// <returns></returns>
		[GraphName("publishedOnPublication")]
		[GraphBackingField(nameof(_publishedOnPublication))]
		public bool PublishedOnPublication([GraphNonNullableParameter] [GraphParameterType(typeof(ID))] string publicationId) => _publishedOnPublication;
		
		/// <summary>
		/// The rules used to assign products to the collection. This applies only to smart collections.
		/// </summary>
		[GraphName("ruleSet")]
		public CollectionRuleSet RuleSet { get; set; }
		
		/// <summary>
		/// SEO information for the collection.
		/// </summary>
		[GraphName("seo")]
		public Seo Seo { get; set; }
		
		/// <summary>
		/// The order in which the collection's products are sorted.
		/// </summary>
		[GraphName("sortOrder")]
		public CollectionSortOrder CollectionSortOrder { get; set; }

		/// <summary>
		/// The storefront ID of the collection.
		/// </summary>
		[GraphName("storefrontId")]
		public string StorefrontId { get; set; }
		
		/// <summary>
		/// The theme template used when viewing this collection in a store.
		/// </summary>
		[GraphName("templateSuffix")]
		public string TemplateSuffix { get; set; }
		
		/// <summary>
		/// The title of the collection.
		/// </summary>
		[GraphName("title")]
		public string Title { get; set; }

		private List<PublishedTranslation> _translations;

		/// <summary>
		/// The translations associated with the resource.
		/// </summary>
		/// <param name="locale"></param>
		/// <returns></returns>
		[GraphName("translation")]
		[GraphBackingField(nameof(_translations))]
		public List<PublishedTranslation> Translations([GraphNonNullableParameter] string locale) => _translations;
		
		[GraphName("updatedAt")]
		public DateTime UpdatedAt { get; set; }
	}
}