using System.Collections.Generic;
using LinqToGraphQL.Attributes;
using LinqToGraphQL.Translator.Behavior;
using LinqToShopify.GraphQL.Admin.Context.Inventory.Types.Inputs;
using LinqToShopify.GraphQL.Admin.Context.Metafield.Types.Inputs;
using LinqToShopify.GraphQL.Admin.Context.ProductCollection.Global.Types.Weight.Enum;
using LinqToShopify.GraphQL.Admin.Context.ProductCollection.Types.Product.Enum.Variant;
using ProductVariantInventoryManagement = LinqToShopify.GraphQL.Admin.Context.ProductCollection.Types.Product.Variant.ProductVariantInventoryManagement;

namespace LinqToShopify.GraphQL.Admin.Context.ProductCollection.Types.Product.Input.Variant
{
	/// <summary>
	/// Specifies a product variant to create or update.
	/// </summary>
	public class ProductVariantInput
	{
		/// <summary>
		/// The value of the barcode associated with the product.
		/// </summary>
		[GraphNameBehavior(TranslatorBehavior.CamelCase)]
		public string Barcode { get; set; }
		
		/// <summary>
		/// The compare-at price of the variant.
		/// </summary>
		[GraphNameBehavior(TranslatorBehavior.CamelCase)]
		public string CompareAtPrice { get; set; }
		
		/// <summary>
		/// The ID of the fulfillment service associated with the variant.
		/// </summary>
		[GraphNameBehavior(TranslatorBehavior.CamelCase)]
		public string FulfillmentServiceId { get; set; }
		
		/// <summary>
		/// The Harmonized System Code (or HS Tariff Code) for the variant.
		/// </summary>
		[GraphNameBehavior(TranslatorBehavior.CamelCase)]
		public string HarmonizedSystemCode { get; set; }
		
		/// <summary>
		/// Specifies the product variant to update or create a new variant if absent.
		/// </summary>
		[GraphNameBehavior(TranslatorBehavior.CamelCase)]
		public string Id { get; set; }
		
		/// <summary>
		/// The ID of the image that's associated with the variant.
		/// </summary>
		[GraphNameBehavior(TranslatorBehavior.CamelCase)]
		public string ImageId { get; set; }
		
		/// <summary>
		/// The URL of an image to associate with the variant. This field can only be used through mutations that create product images and must match one of the URLs being created on the product.
		/// </summary>
		[GraphNameBehavior(TranslatorBehavior.CamelCase)]
		public string ImageSrc { get; set; }
		
		/// <summary>
		/// Inventory Item associated with the variant, used for unit cost.
		/// </summary>
		[GraphNameBehavior(TranslatorBehavior.CamelCase)]
		public InventoryItemInput InventoryItem { get; set; }
		
		/// <summary>
		/// The fulfillment service that tracks the number of items in stock for the product variant. If you track the inventory yourself using the admin, then set the value to shopify. Valid values: shopify or the handle of a fulfillment service that has inventory management enabled. This argument is deprecated: Use tracked attribute on inventoryItem instead.
		/// </summary>
		[GraphNameBehavior(TranslatorBehavior.CamelCase)]
		public ProductVariantInventoryManagement InventoryManagement { get; set; }
		
		/// <summary>
		/// Whether customers are allowed to place an order for the product variant when it's out of stock.
		/// </summary>
		[GraphNameBehavior(TranslatorBehavior.CamelCase)]
		public ProductVariantInventoryPolicy InventoryPolicy { get; set; }
		
		/// <summary>
		/// Create only field. The inventory quantities at each location where the variant is stocked.
		/// </summary>
		[GraphNameBehavior(TranslatorBehavior.CamelCase)]
		public List<InventoryLevelInput> InventoryQuantities { get; set; }
		
		/// <summary>
		/// The URL of the media to associate with the variant. This field can only be used in mutations that create media images and must match one of the URLs being created on the product. This field only accepts one value.
		/// </summary>
		[GraphNameBehavior(TranslatorBehavior.CamelCase)]
		public List<string> MediaSrc { get; set; }
		
		/// <summary>
		/// Additional customizable information about the product variant.
		/// </summary>
		[GraphNameBehavior(TranslatorBehavior.CamelCase)]
		public List<MetafieldInput> Metafields { get; set; }
		
		/// <summary>
		/// The custom properties that a shop owner uses to define product variants.
		/// </summary>
		[GraphNameBehavior(TranslatorBehavior.CamelCase)]
		public List<string> Options { get; set; }

		/// <summary>
		/// The order of the product variant in the list of product variants. The first position in the list is 1.
		/// </summary>
		[GraphNameBehavior(TranslatorBehavior.CamelCase)]
		public int Position { get; set; }
		
		/// <summary>
		/// The price of the variant.
		/// </summary>
		[GraphNameBehavior(TranslatorBehavior.CamelCase)]
		public string Price { get; set; }
		
		/// <summary>
		/// The private metafields to associated with this product.
		/// </summary>
		[GraphNameBehavior(TranslatorBehavior.CamelCase)]
		public List<PrivateMetafieldInput> PrivateMetafields { get; set; }
		
		/// <summary>
		/// Create only required field. Specifies the product on which to create the variant.
		/// </summary>
		[GraphNameBehavior(TranslatorBehavior.CamelCase)]
		public string ProductId { get; set; }
		
		/// <summary>
		/// Whether the variant requires shipping.
		/// </summary>
		[GraphNameBehavior(TranslatorBehavior.CamelCase)]
		public bool RequiresShipping { get; set; }
		
		/// <summary>
		/// The SKU for the variant.
		/// </summary>
		[GraphNameBehavior(TranslatorBehavior.CamelCase)]
		public string Sku { get; set; }
		
		/// <summary>
		/// The tax code associated with the variant.
		/// </summary>
		[GraphNameBehavior(TranslatorBehavior.CamelCase)]
		public string TaxCode { get; set; }
		
		/// <summary>
		/// Whether the variant is taxable.
		/// </summary>
		[GraphNameBehavior(TranslatorBehavior.CamelCase)]
		public bool Taxable { get; set; }

		/// <summary>
		/// The weight of the variant.
		/// </summary>
		[GraphNameBehavior(TranslatorBehavior.CamelCase)]
		public float Weight { get; set; }
		
		/// <summary>
		/// The unit of weight that's used to measure the variant.
		/// </summary>
		[GraphNameBehavior(TranslatorBehavior.CamelCase)]
		public WeightUnit WeightUnit { get; set; }
	}
}