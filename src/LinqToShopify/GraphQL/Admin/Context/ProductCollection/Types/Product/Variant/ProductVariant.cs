using System;
using System.Collections.Generic;
using LinqToGraphQL.Attributes;
using LinqToGraphQL.Attributes.Method;
using LinqToShopify.GraphQL.Admin.Context.Common.Connections;
using LinqToShopify.GraphQL.Admin.Context.Common.Types.CurrencyCode;
using LinqToShopify.GraphQL.Admin.Context.Common.Types.Image;
using LinqToShopify.GraphQL.Admin.Context.Global.LegacyInteroperability;
using LinqToShopify.GraphQL.Admin.Context.Global.Navigable;
using LinqToShopify.GraphQL.Admin.Context.Global.Node;
using LinqToShopify.GraphQL.Admin.Context.Inventory.Types;
using LinqToShopify.GraphQL.Admin.Context.Metafield.Types;
using LinqToShopify.GraphQL.Admin.Context.Metafield.Types.Interface;
using LinqToShopify.GraphQL.Admin.Context.ProductCollection.Connections;
using LinqToShopify.GraphQL.Admin.Context.ProductCollection.Global.Types.Weight.Enum;
using LinqToShopify.GraphQL.Admin.Context.ProductCollection.Types.Product.Enum.Variant;
using LinqToShopify.GraphQL.Admin.Context.Translation.Types.Interface;
using LinqToShopify.GraphQL.Admin.Context.Translation.Types.Translation;

namespace LinqToShopify.GraphQL.Admin.Context.ProductCollection.Types.Product.Variant
{
	public class ProductVariant : Node, IHasMetafields, IHasPublishedTranslations, ILegacyInteroperability, INavigable
	{

		private MetafieldConnection _metafields;

		/// <summary>
		/// List of metafields that belong to the resource.
		/// </summary>
		/// <param name="after"></param>
		/// <param name="before"></param>
		/// <param name="first"></param>
		/// <param name="last"></param>
		/// <param name="namespace"></param>
		/// <param name="reverse"></param>
		/// <returns></returns>
		[GraphName("metafields")]
		[GraphBackingField(nameof(_metafields))]
		public MetafieldConnection Metafields(string after = default, 
			string before = default, 
			int? first = null, 
			int? last = null, 
			[GraphName("namespace")] string @namespace = default, 
			bool reverse = default) =>
			_metafields;

		private ProductVariantPricePairConnection _presentmentPrices;

		[GraphName("presentmentPrices")]
		public ProductVariantPricePairConnection PresentmentPrices(string after = default,
			string before = default,
			int? first = null,
			int? last = null,
			List<CurrencyCode> presentmentCurrencies = default,
			bool reverse = default) => _presentmentPrices;
		
		private PrivateMetafieldConnection _privateMetafields;

		/// <summary>
		/// List of private metafields that belong to the resource.
		/// </summary>
		/// <param name="after">Returns the elements that come after the specified cursor.</param>
		/// <param name="before">Returns the elements that come before the specified cursor.</param>
		/// <param name="first">Returns up to the first n elements from the list.</param>
		/// <param name="last">Returns up to the last n elements from the list.</param>
		/// <param name="namespace">Filter the private metafields by namespace.</param>
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

		/// <summary>
		/// Whether the product variant is available for sale.
		/// </summary>
		[GraphName("availableForSale")]
		public bool AvailableForSale { get; set; }
		
		/// <summary>
		/// The value of the barcode associated with the product.
		/// </summary>
		[GraphName("barcode")]
		public string Barcode { get; set; }
		
		/// <summary>
		/// The compare-at price of the variant in the default shop currency.
		/// </summary>
		[GraphName("compareAtPrice")]
		public string CompareAtPrice { get; set; }
		
		/// <summary>
		/// The date and time when the variant was created.
		/// </summary>
		[GraphName("createdAt")]
		public DateTime CreatedAt { get; set; }

		/// <summary>
		/// A default cursor that returns the single next record, sorted ascending by ID.
		/// </summary>
		[GraphName("defaultCursor")]
		public string DefaultCursor { get; set; }
		
		// TODO: Implement deliveryProfile
		
		/// <summary>
		/// Display name of the variant, based on product's title + variant's title.
		/// </summary>
		[GraphName("displayName")]
		public string DisplayName { get; set; }
		
		// TODO: Implement fulfillmentService
		
		// TODO: Implement fulfillmentServiceEditable
		
		/// <summary>
		/// The featured image for the variant.
		/// </summary>
		[GraphName("image")]
		public Image Image { get; set; }
		
		/// <summary>
		/// The inventory item, which is used to query for inventory information.
		/// </summary>
		[GraphName("inventoryItem")]
		public InventoryItem InventoryItem { get; set; }
		
		/// <summary>
		/// Whether customers are allowed to place an order for the product variant when it's out of stock.
		/// </summary>
		[GraphName("inventoryPolicy")]
		public ProductVariantInventoryPolicy InventoryPolicy { get; set; }
		
		/// <summary>
		/// The total sellable quantity of the variant.
		/// </summary>
		[GraphName("inventoryQuantity")]
		public int InventoryQuantity { get; set; }
		
		/// <summary>
		/// The ID of the corresponding resource in the REST Admin API.
		/// </summary>
		public ulong LegacyResourceId { get; set; }
		
		private Metafield.Types.Metafield _metafield;
		
		/// <summary>
		/// Returns a metafield by namespace and key that belongs to the resource.
		/// </summary>
		/// <param name="key">The key for the private metafield.</param>
		/// <param name="namespace">The namespace for the private metafield.</param>
		/// <returns></returns>
		[GraphName("metafield")]
		[GraphBackingField(nameof(_metafield))]
		public Metafield.Types.Metafield Metafield([GraphNonNullableParameter] string key, [GraphName("namespace")] [GraphNonNullableParameter] string @namespace) => _metafield;
		
		/// <summary>
		/// The order of the product variant in the list of product variants. The first position in the list is 1.
		/// </summary>
		[GraphName("position")]
		public int Position { get; set; }
		
		/// <summary>
		/// The price of the product variant in the default shop currency.
		/// </summary>
		[GraphName("price")]
		public string Price { get; set; }

		private Metafield.Types.Metafield _privateMetafield;

		/// <summary>
		/// Returns a private metafield by namespace and key that belongs to the resource.
		/// </summary>
		/// <param name="key">The key for the private metafield.</param>
		/// <param name="namespace">The namespace for the private metafield.</param>
		/// <returns></returns>
		[GraphName("privateMetafield")]
		[GraphBackingField(nameof(_privateMetafield))]
		public PrivateMetafield PrivateMetafield([GraphNonNullableParameter] string key, [GraphName("namespace")] [GraphNonNullableParameter] string @namespace) => new PrivateMetafield();

		/// <summary>
		/// The product that this variant belongs to.
		/// </summary>
		[GraphName("product")]
		public Product Product { get; set; }
		
		/// <summary>
		/// List of product options applied to the variant.
		/// </summary>
		[GraphName("selectedOptions")]
		public List<SelectedOption.SelectedOption> SelectedOptions { get; set; }
		
		/// <summary>
		/// Count of selling plan groups associated with the product variant.
		/// </summary>
		[GraphName("sellingPlanGroupCount")]
		public int SellingPlanGroupCount { get; set; }
		
		/// <summary>
		/// An identifier for the product variant in the shop. Required in order to connect to a fulfillment service.
		/// </summary>
		[GraphName("sku")]
		public string Sku { get; set; }
		
		/// <summary>
		/// The storefront ID of the product variant.
		/// </summary>
		[GraphName("storefrontId")]
		public string StorefrontId { get; set; }
		
		/// <summary>
		/// The tax code for the product variant.
		/// </summary>
		[GraphName("taxCode")]
		public string TaxCode { get; set; }
		
		/// <summary>
		/// Whether a tax is charged when the product variant is sold.
		/// </summary>
		[GraphName("taxable")]
		public bool Taxable { get; set; }
		
		/// <summary>
		/// The title of the product variant.
		/// </summary>
		[GraphName("title")]
		public string Title { get; set; }
		
		private List<PublishedTranslation> _translations;

		/// <summary>
		/// The translations associated with the resource.
		/// </summary>
		/// <param name="locale">The translations associated with the resource.</param>
		/// <returns></returns>
		[GraphName("translations")]
		[GraphBackingField(nameof(_translations))]
		public List<PublishedTranslation> Translations(string locale) => _translations;

		/// <summary>
		/// The date and time when the product was last modified. A product's updatedAt value can change for different reasons. For example, if an order is placed for a product that has inventory tracking set up, then the inventory adjustment is counted as an update.
		/// </summary>
		[GraphName("updatedAt")]
		public DateTime UpdatedAt { get; set; }
		
		/// <summary>
		/// The weight of the product variant in the unit system specified with weight_unit.
		/// </summary>
		[GraphName("weight")]
		public float Weight { get; set; }
		
		/// <summary>
		/// The unit of measurement that applies to the product variant's weight. If you don't specify a value for weight_unit, then the shop's default unit of measurement is applied. Valid values: g, kg, oz, lb.
		/// </summary>
		[GraphName("weightUnit")]
		public WeightUnit WeightUnit { get; set; }
	}
}