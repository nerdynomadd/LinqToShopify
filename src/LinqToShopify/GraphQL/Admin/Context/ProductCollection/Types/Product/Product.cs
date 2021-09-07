using System;
using System.Collections.Generic;
using LinqToGraphQL.Attributes;
using LinqToGraphQL.Attributes.Method;
using LinqToShopify.GraphQL.Admin.Context.App.Types.ResourceFeedback;
using LinqToShopify.GraphQL.Admin.Context.Common.Connections;
using LinqToShopify.GraphQL.Admin.Context.Common.Types.Id;
using LinqToShopify.GraphQL.Admin.Context.Common.Types.Image;
using LinqToShopify.GraphQL.Admin.Context.Global.LegacyInteroperability;
using LinqToShopify.GraphQL.Admin.Context.Global.Navigable;
using LinqToShopify.GraphQL.Admin.Context.Metafield.Types;
using LinqToShopify.GraphQL.Admin.Context.Metafield.Types.Interface;
using LinqToShopify.GraphQL.Admin.Context.OnlineStore.Types.Seo;
using LinqToShopify.GraphQL.Admin.Context.ProductCollection.Connections;
using LinqToShopify.GraphQL.Admin.Context.ProductCollection.Global.Connection;
using LinqToShopify.GraphQL.Admin.Context.ProductCollection.Global.Types.Media;
using LinqToShopify.GraphQL.Admin.Context.ProductCollection.Global.Types.Publishable;
using LinqToShopify.GraphQL.Admin.Context.ProductCollection.Types.Collection.Enum;
using LinqToShopify.GraphQL.Admin.Context.ProductCollection.Types.Product.Enum;
using LinqToShopify.GraphQL.Admin.Context.ProductCollection.Types.Product.Enum.Image;
using LinqToShopify.GraphQL.Admin.Context.ProductCollection.Types.Product.Enum.Media;
using LinqToShopify.GraphQL.Admin.Context.ProductCollection.Types.Product.Enum.Variant;
using LinqToShopify.GraphQL.Admin.Context.ProductCollection.Types.Product.Option;
using LinqToShopify.GraphQL.Admin.Context.ProductCollection.Types.Product.Price;
using LinqToShopify.GraphQL.Admin.Context.Translation.Types.Interface;
using LinqToShopify.GraphQL.Admin.Context.Translation.Types.Translation;

namespace LinqToShopify.GraphQL.Admin.Context.ProductCollection.Types.Product
{
	public class Product : Publishable, IHasMetafields, IHasPublishedTranslations, ILegacyInteroperability, INavigable
	{
		private CollectionConnection _collections;
		
		/// <summary>
		/// A list of the collections that include the product.
		/// </summary>
		/// <param name="after">Returns the elements that come after the specified cursor.</param>
		/// <param name="before">Returns the elements that come before the specified cursor.</param>
		/// <param name="first">Returns up to the first n elements from the list.</param>
		/// <param name="last">Returns up to the last n elements from the list.</param>
		/// <param name="query"></param>
		/// <param name="reverse">Reverse the order of the underlying list.</param>
		/// <param name="sortKey">Sort the underlying list by the given key.</param>
		/// <returns></returns>
		[GraphName("collections")]
		[GraphBackingField(nameof(_collections))]
		public CollectionConnection Collections(string after = default,
			string before = default,
			int? first = null,
			int? last = null,
			string query = default,
			bool reverse = false,
			CollectionSortKeys sortKey = CollectionSortKeys.ID) => _collections;

		private ImageConnection _images;

		/// <summary>
		/// The images associated with the product.
		/// </summary>
		/// <param name="after">Returns the elements that come after the specified cursor.</param>
		/// <param name="before">Returns the elements that come before the specified cursor.</param>
		/// <param name="first">Returns up to the first n elements from the list.</param>
		/// <param name="last">Returns up to the last n elements from the list.</param>
		/// <param name="reverse">Reverse the order of the underlying list.</param>
		/// <param name="sortKey">Sort the underlying list by the given key.</param>
		/// <returns></returns>
		[GraphName("images")]
		[GraphBackingField(nameof(_images))]
		public ImageConnection Images(string? after = null,
			string? before = null,
			int? first = null,
			int? last = null,
			bool? reverse = false,
			ProductImageSortKeys sortKey = ProductImageSortKeys.POSITION) => _images;
		
		private MediaConnection _media;
		
		/// <summary>
		/// The media associated with the product. This can include images, 3D models, or videos.
		/// </summary>
		/// <param name="after">Returns the elements that come after the specified cursor.</param>
		/// <param name="before">Returns the elements that come before the specified cursor.</param>
		/// <param name="first">Returns up to the first n elements from the list.</param>
		/// <param name="last">Returns up to the last n elements from the list.</param>
		/// <param name="reverse">Reverse the order of the underlying list.</param>
		/// <param name="sortKey">Sort the underlying list by the given key.</param>
		/// <returns></returns>
		[GraphName("media")]
		[GraphBackingField(nameof(_media))]
		public MediaConnection Media(string? after = null,
			string? before = null,
			int? first = null,
			int? last = null,
			bool? reverse = false,
			ProductMediaSortKeys sortKey = ProductMediaSortKeys.POSITION) => _media;
		
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
			string before = default,
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
		
		private ProductVariantConnection _variants;

		[GraphName("variants")]
		[GraphBackingField(nameof(_variants))]
		public ProductVariantConnection Variants(string after = null,
			string before = null,
			int? first = null,
			int? last = null,
			bool reverse = false,
			ProductVariantSortKeys sortKey = ProductVariantSortKeys.POSITION) => _variants;
		
		/// <summary>
		/// A default cursor that returns the single next record, sorted ascending by ID.
		/// </summary>
		[GraphName("defaultCursor")]
		public string DefaultCursor { get; set; }

		private string _description;
		
		/// <summary>
		/// A stripped description of the product, single line with HTML tags removed.
		/// </summary>
		/// <param name="truncateAt">Truncates string after the given length.</param>
		/// <returns></returns>
		[GraphName("description")]
		[GraphBackingField(nameof(_description))]
		public string Description(int truncateAt) => _description;
		
		/// <summary>
		/// The description of the product, complete with HTML formatting.
		/// </summary>
		[GraphName("descriptionHtml")]
		public string DescriptionHtml { get; set; }
		
		/// <summary>
		/// The featured image for the product.
		/// </summary>
		[GraphName("featuredImage")]
		public Image FeaturedImage { get; set; }
		
		/// <summary>
		/// The featured media for the product.
		/// </summary>
		[GraphName("featuredMedia")]
		public Media FeaturedMedia { get; set; }
		
		/// <summary>
		/// Information about the product that's provided through resource feedback.
		/// </summary>
		[GraphName("feedback")]
		public ResourceFeedback Feedback { get; set; }
		
		/// <summary>
		/// The theme template used when viewing the gift card in a store.
		/// </summary>
		[GraphName("giftCardTemplateSuffix")]
		public string GiftCardTemplateSuffix { get; set; }
		
		/// <summary>
		/// A unique human-friendly string of the product's title.
		/// </summary>
		[GraphName("handle")]
		public string Handle { get; set; }
		
		/// <summary>
		/// Whether the product has only a single variant with the default option and value.
		/// </summary>
		[GraphName("hasOnlyDefaultVariant")]
		public bool HasOnlyDefaultVariant { get; set; }
		
		/// <summary>
		/// Whether the product has out of stock variants.
		/// </summary>
		[GraphName("hasOutOfStockVariants")]
		public bool HasOutOfStockVariants { get; set; }

		private bool _inCollection;

		/// <summary>
		/// Whether the product is in a given collection.
		/// </summary>
		/// <param name="id">The ID of the collection to check.</param>
		/// <returns></returns>
		[GraphName("inCollection")]
		public bool InCollection([GraphNonNullableParameter] [GraphParameterType(typeof(ID))] string id) => _inCollection;
		
		/// <summary>
		/// Whether the product is a gift card.
		/// </summary>
		[GraphName("isGiftCard")]
		public bool IsGiftCard { get; set; }
		
		/// <summary>
		/// The ID of the corresponding resource in the REST Admin API.
		/// </summary>
		[GraphName("legacyResourceId")]
		public ulong LegacyResourceId { get; set; }
		
		/// <summary>
		/// Total count of media belonging to a product.
		/// </summary>
		[GraphName("mediaCount")]
		public int MediaCount { get; set; }
		
		private Metafield.Types.Metafield _metafield;

		/// <summary>
		/// Returns a metafield by namespace and key that belongs to the resource.
		/// </summary>
		/// <param name="key">The key for the metafield.</param>
		/// <param name="namespace">The key for the metafield.</param>
		/// <returns></returns>
		[GraphName("metafield")]
		[GraphBackingField(nameof(_metafield))]
		public Metafield.Types.Metafield Metafield(string key, string @namespace) => _metafield;
		
		/// <summary>
		/// The online store preview URL.
		/// </summary>
		[GraphName("onlineStorePreviewUrl")]
		public string OnlineStorePreviewUrl { get; set; }
		
		/// <summary>
		/// The online store URL for the product. A value of null indicates that the product is not published to the Online Store sales channel.
		/// </summary>
		[GraphName("onlineStoreUrl")]
		public string OnlineStoreUrl { get; set; }

		private List<ProductOption> _options;

		/// <summary>
		/// A list of product options. The limit is specified by Shop.resourceLimits.maxProductOptions.
		/// </summary>
		/// <param name="first">Truncate the array result to this size.</param>
		/// <returns></returns>
		[GraphName("options")]
		[GraphBackingField(nameof(_options))]
		public List<ProductOption> Options(int first) => _options;
		
		/// <summary>
		/// The price range of the product with prices formatted as decimals.
		/// </summary>
		[GraphName("priceRangeV2")]
		public ProductPriceRangeV2 PriceRangeV2 { get; set; }
		
		private PrivateMetafield _privateMetafield;

		/// <summary>
		/// Returns a private metafield by namespace and key that belongs to the resource.
		/// </summary>
		/// <param name="key">The key for the private metafield.</param>
		/// <param name="namespace">The namespace for the private metafield.</param>
		/// <returns></returns>
		[GraphName("privateMetafield")]
		[GraphBackingField(nameof(_privateMetafield))]
		public PrivateMetafield PrivateMetafield(string key, string @namespace) => _privateMetafield;

		/// <summary>
		/// The product type specified by the merchant.
		/// </summary>
		[GraphName("productType")]
		public string ProductType { get; set; }
		
		/// <summary>
		/// The date and time (ISO 8601 format) when the product was published to the Online Store.
		/// </summary>
		[GraphName("publishedAt")]
		public DateTime PublishedAt { get; set; }
		
		/// <summary>
		/// Whether the product can only be purchased with a selling plan (subscription). Products that are sold on subscription (requiresSellingPlan: true) can be updated only for online stores. If you update a product to be subscription only, then the product is unpublished from all channels except the online store.
		/// </summary>
		[GraphName("requiresSellingPlan")]
		public bool RequiresSellingPlan { get; set; }
		
		/// <summary>
		/// Count of selling plan groups associated with the product.
		/// </summary>
		[GraphName("sellingPlanGroupCount")]
		public int SellingPlanGroupCount { get; set; }
		
		/// <summary>
		/// SEO information of the product.
		/// </summary>
		[GraphName("seo")]
		public Seo Seo { get; set; }
		
		/// <summary>
		/// The product status. This controls visibility across all channels.
		/// </summary>
		[GraphName("status")]
		public ProductStatus Status { get; set; }
		
		/// <summary>
		/// The storefront ID of the product.
		/// </summary>
		[GraphName("storefrontId")]
		public string StorefrontId { get; set; }
		
		/// <summary>
		/// A comma separated list of tags associated with the product. Updating tags overwrites any existing tags that were previously added to the product. To add new tags without overwriting existing tags, use the tagsAdd mutation.
		/// </summary>
		[GraphName("tags")]
		public List<string> Tags { get; set; }
		
		/// <summary>
		/// The theme template used when viewing the product in a store.
		/// </summary>
		[GraphName("templateSuffix")]
		public string TemplateSuffix { get; set; }
		
		/// <summary>
		/// The title of the product.
		/// </summary>
		[GraphName("title")]
		public string Title { get; set; }
		
		/// <summary>
		/// The quantity of inventory in stock.
		/// </summary>
		[GraphName("totalInventory")]
		public int TotalInventory { get; set; }
		
		/// <summary>
		/// The number of variants that are associated with the product.
		/// </summary>
		[GraphName("totalVariants")]
		public int TotalVariants { get; set; }
		
		/// <summary>
		/// Whether inventory tracking has been enabled for the product.
		/// </summary>
		[GraphName("tracksInventory")]
		public int TracksInventory { get; set; }
		
		private List<PublishedTranslation> _translations;
		
		/// <summary>
		/// The translations associated with the resource.
		/// </summary>
		/// <param name="locale"></param>
		/// <returns></returns>
		[GraphName("translations")]
		[GraphBackingField(nameof(_translations))]
		public List<PublishedTranslation> Translations([GraphNonNullableParameter] string locale) => _translations;
		
		/// <summary>
		/// The date and time when the product was last modified. A product's updatedAt value can change for different reasons. For example, if an order is placed for a product that has inventory tracking set up, then the inventory adjustment is counted as an update.
		/// </summary>
		[GraphName("updatedAt")]
		public DateTime UpdatedAt { get; set; }
		
		/// <summary>
		/// The name of the product's vendor.
		/// </summary>
		[GraphName("vendor")]
		public string Vendor  { get; set; }
	}
}