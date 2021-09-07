using System.Collections.Generic;
using LinqToGraphQL.Attributes;
using LinqToShopify.GraphQL.Admin.Context.Common.Types.Image.Mutation.Input;
using LinqToShopify.GraphQL.Admin.Context.Metafield.Types.Inputs;
using LinqToShopify.GraphQL.Admin.Context.OnlineStore.Types.Seo.Mutation.Input;
using LinqToShopify.GraphQL.Admin.Context.ProductCollection.Types.Collection.Enum;

namespace LinqToShopify.GraphQL.Admin.Context.ProductCollection.Types.Collection.Input
{
	public class CollectionInput
	{
		/// <summary>
		/// The description of the collection, in HTML format.
		/// </summary>
		[GraphName("descriptionHtml")]
		public string DescriptionHtml { get; set; }
		
		/// <summary>
		/// A unique human-friendly string for the collection. Automatically generated from the collection's title.
		/// </summary>
		[GraphName("handle")]
		public string Handle { get; set; }
		
		/// <summary>
		/// Specifies the collection to update or create a new collection if absent.
		/// </summary>
		[GraphName("id")]
		public string Id { get; set; }
		
		/// <summary>
		/// The image associated with the collection.
		/// </summary>
		[GraphName("image")]
		public ImageInput Image { get; set; }
		
		/// <summary>
		/// The metafields to associate with this collection.
		/// </summary>
		[GraphName("metafields")]
		public List<MetafieldInput> Metafields { get; set; }
		
		/// <summary>
		/// The private metafields to associated with this product.
		/// </summary>
		[GraphName("privateMetafields")]
		public List<PrivateMetafieldInput> PrivateMetafields { get; set; }
		
		/// <summary>
		/// Initial list of collection products. Only valid with productCreate and without rules.
		/// </summary>
		[GraphName("products")]
		public List<string> Products { get; set; }
		
		/// <summary>
		/// Indicates whether a redirect is required after a new handle has been provided. If true, then the old handle is redirected to the new one automatically.
		/// </summary>
		[GraphName("redirectNewHandle")]
		public bool RedirectNewHandle { get; set; }
		
		/// <summary>
		/// The rules used to assign products to the collection.
		/// </summary>
		[GraphName("ruleSet")]
		public CollectionRuleSetInput RuleSet { get; set; }
		
		/// <summary>
		/// SEO information for the collection.
		/// </summary>
		[GraphName("seo")]
		public SEOInput Seo { get; set; }
		
		/// <summary>
		/// The order in which the collection's products are sorted.
		/// </summary>
		[GraphName("sortOrder")]
		public CollectionSortOrder SortOrder { get; set; }
		
		/// <summary>
		/// The theme template used when viewing the collection in a store.
		/// </summary>
		[GraphName("templateSuffix")]
		public string TemplateSuffix { get; set; }
		
		/// <summary>
		/// Required for creating a new collection.
		/// </summary>
		[GraphName("title")]
		public string Title { get; set; }
	}
}