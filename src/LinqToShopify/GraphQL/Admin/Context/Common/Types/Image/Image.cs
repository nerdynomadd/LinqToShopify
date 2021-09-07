using LinqToGraphQL.Attributes;
using LinqToGraphQL.Attributes.Method;
using LinqToShopify.GraphQL.Admin.Context.Common.Connections;
using LinqToShopify.GraphQL.Admin.Context.Common.Types.Image.Query.Input;
using LinqToShopify.GraphQL.Admin.Context.Global.Node;
using LinqToShopify.GraphQL.Admin.Context.Metafield.Types;

namespace LinqToShopify.GraphQL.Admin.Context.Common.Types.Image
{
	public class Image : Node
	{
		/// <summary>
		/// A word or phrase to share the nature or contents of an image.
		/// </summary>
		[GraphName("altText")]
		public string AltText { get; set; }
		
		/// <summary>
		/// The original height of the image in pixels. Returns null if the image is not hosted by Shopify.
		/// </summary>
		[GraphName("height")]
		public int Height { get; set; }
		
		/// <summary>
		/// The original width of the image in pixels. Returns null if the image is not hosted by Shopify.
		/// </summary>
		[GraphName("width")]
		public int Width { get; set; }
		
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

		private Metafield.Types.Metafield _metafield;
		
		/// <summary>
		/// Returns a metafield by namespace and key that belongs to the resource.
		/// </summary>
		/// <param name="key">The key for the private metafield.</param>
		/// <param name="namespace">The namespace for the private metafield.</param>
		/// <returns></returns>
		[GraphName("metafield")]
		[GraphBackingField(nameof(_metafield))]
		public Metafield.Types.Metafield Metafield([GraphNonNullableParameter] string key, [GraphName("namespace")] [GraphNonNullableParameter] string @namespace) => new Metafield.Types.Metafield();
		
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
		/// The location of the original image as a URL.
		/// If there are any existing transformations in the original source URL, they will remain and not be stripped.
		/// </summary>
		[GraphName("originalSrc")]
		public string OriginalSrc { get; set; }

		private string _transformedSrc;
		
		/// <summary>
		/// The location of the transformed image as a URL.
		/// All transformation arguments are considered "best-effort". If they can be applied to an image, they will be. Otherwise any transformations which an image type does not support will be ignored.
		/// </summary>
		/// <param name="crop">Crops the image according to the specified region.</param>
		/// <param name="maxHeight">Image height in pixels between 1 and 5760.</param>
		/// <param name="maxWidth">Image width in pixels between 1 and 5760.</param>
		/// <param name="preferredContentType">Best effort conversion of image into content type (SVG -> PNG, Anything -> JGP, Anything -> WEBP are supported).</param>
		/// <param name="scale">Image size multiplier for high-resolution retina displays. Must be between 1 and 3.</param>
		/// <returns></returns>
		[GraphName("transformedSrc")]
		[GraphBackingField(nameof(_transformedSrc))]
		public string TransformedSrc(CropRegion? crop = null, int? maxHeight = null, int? maxWidth = null, ImageContentType? preferredContentType = null, int? scale = 1) => _transformedSrc;

	}
}