using System.Collections.Generic;
using LinqToGraphQL.Attributes;
using LinqToGraphQL.Translator.Behavior;
using LinqToShopify.GraphQL.Admin.Context.Common.Types.Image.Mutation.Input;
using LinqToShopify.GraphQL.Admin.Context.Metafield.Types.Inputs;
using LinqToShopify.GraphQL.Admin.Context.OnlineStore.Types.Seo.Mutation.Input;
using LinqToShopify.GraphQL.Admin.Context.ProductCollection.Types.Product.Enum;
using LinqToShopify.GraphQL.Admin.Context.ProductCollection.Types.Product.Input.Variant;

namespace LinqToShopify.GraphQL.Admin.Context.ProductCollection.Types.Product.Input
{
	/// <summary>
	/// Specifies the input fields required to create a product.
	/// </summary>
	public class ProductInput
	{
		/// <summary>
		/// A description of the product. Supports HTML formatting. This argument is deprecated: Use descriptionHtml instead.
		/// </summary>
		[GraphNameBehavior(TranslatorBehavior.CamelCase)]
		public string BodyHtml { get; set; }
		
		/// <summary>
		/// The IDs of the collections that this product will be added to.
		/// </summary>
		[GraphNameBehavior(TranslatorBehavior.CamelCase)]
		public List<string> CollectionsToJoin { get; set; }
		
		/// <summary>
		/// The IDs of collections that will no longer include the product.
		/// </summary>
		[GraphNameBehavior(TranslatorBehavior.CamelCase)]
		public List<string> CollectionsToLeave { get; set; }
		
		/// <summary>
		/// The description of the product, complete with HTML formatting.
		/// </summary>
		[GraphNameBehavior(TranslatorBehavior.CamelCase)]
		public string DescriptionHtml { get; set; }
		
		/// <summary>
		/// Whether the product is a gift card.
		/// </summary>
		[GraphNameBehavior(TranslatorBehavior.CamelCase)]
		public bool GiftCard  { get; set; }
		
		/// <summary>
		/// The theme template used when viewing the gift card in a store.
		/// </summary>
		[GraphNameBehavior(TranslatorBehavior.CamelCase)]
		public string GiftCardTemplateSuffix  { get; set; }
		
		/// <summary>
		/// A unique human-friendly string for the product. Automatically generated from the product's title.
		/// </summary>
		[GraphNameBehavior(TranslatorBehavior.CamelCase)]
		public string Handle  { get; set; }
		
		/// <summary>
		/// Specifies the product to update in productUpdate or creates a new product if absent in productCreate.
		/// </summary>
		[GraphNameBehavior(TranslatorBehavior.CamelCase)]
		public string Id { get; set; }
		
		/// <summary>
		/// The images to associate with the product.
		/// </summary>
		[GraphNameBehavior(TranslatorBehavior.CamelCase)]
		public List<ImageInput> Images { get; set; }
		
		/// <summary>
		/// The metafields to associate with this product.
		/// </summary>
		[GraphNameBehavior(TranslatorBehavior.CamelCase)]
		public List<MetafieldInput> Metafields { get; set; }
		
		/// <summary>
		/// List of custom product options (maximum of 3 per product).
		/// </summary>
		[GraphNameBehavior(TranslatorBehavior.CamelCase)]
		public List<string> Options { get; set; }
		
		/// <summary>
		/// The private metafields to associate with this product.
		/// </summary>
		[GraphNameBehavior(TranslatorBehavior.CamelCase)]
		public List<PrivateMetafieldInput> PrivateMetafields { get; set; }
		
		/// <summary>
		/// The product type specified by the merchant.
		/// </summary>
		[GraphNameBehavior(TranslatorBehavior.CamelCase)]
		public string ProductType { get; set; }
		
		/// <summary>
		/// Whether a redirect is required after a new handle has been provided. If true, then the old handle is redirected to the new one automatically.
		/// </summary>
		[GraphNameBehavior(TranslatorBehavior.CamelCase)]
		public bool RedirectNewHandle { get; set; }
		
		/// <summary>
		/// Whether the product can only be purchased with a selling plan (subscription). Products that are sold exclusively on subscription can only be created on online stores. If set to true on an already existing product, then the product will be marked unavailable on channels that don't support subscriptions.
		/// </summary>
		[GraphNameBehavior(TranslatorBehavior.CamelCase)]
		public bool RequiresSellingPlan { get; set; }
		
		/// <summary>
		/// The SEO information associated with the product.
		/// </summary>
		[GraphNameBehavior(TranslatorBehavior.CamelCase)]
		public SEOInput Seo  { get; set; }
		
		/// <summary>
		/// The status of the product.
		/// </summary>
		[GraphNameBehavior(TranslatorBehavior.CamelCase)]
		public ProductStatus Status  { get; set; }

		/// <summary>
		/// A comma separated list tags that have been added to the product.
		/// </summary>
		[GraphNameBehavior(TranslatorBehavior.CamelCase)]
		public List<string> Tags { get; set; }
		
		/// <summary>
		/// The theme template used when viewing the product in a store.
		/// </summary>
		[GraphNameBehavior(TranslatorBehavior.CamelCase)]
		public string TemplateSuffix { get; set; }
		
		/// <summary>
		/// The title of the product.
		/// </summary>
		[GraphNameBehavior(TranslatorBehavior.CamelCase)]
		public string Title { get; set; }
		
		/// <summary>
		/// A list of variants associated with the product.
		/// </summary>
		[GraphNameBehavior(TranslatorBehavior.CamelCase)]
		public List<ProductVariantInput> Variants { get; set; }
		
		/// <summary>
		/// The name of the product's vendor.
		/// </summary>
		[GraphNameBehavior(TranslatorBehavior.CamelCase)]
		public string Vendor { get; set; }
	}
}