using System.Collections.Generic;
using LinqToGraphQL.Attributes;
using LinqToShopify.GraphQL.Admin.Context.Global.Node;
using LinqToShopify.GraphQL.Admin.Context.ProductCollection.Global.Types.Media;
using LinqToShopify.GraphQL.Admin.Context.ProductCollection.Global.Types.Media.Enum;
using LinqToShopify.GraphQL.Admin.Context.ProductCollection.Global.Types.Media.Interface;

namespace LinqToShopify.GraphQL.Admin.Context.ProductCollection.Global.Types.Video
{
	/// <summary>
	/// Represents a Shopify hosted video.
	/// </summary>
	public class Video : INode, IMedia
	{
		/// <summary>
		/// A word or phrase to share the nature or contents of a media.
		/// </summary>
		[GraphName("alt")]
		public string Alt { get; set; }
		
		/// <summary>
		/// The URL.
		/// </summary>
		[GraphName("embeddedUrl")]
		public string EmbeddedUrl { get; set; }
		
		/// <summary>
		/// The host of the external video.
		/// </summary>
		[GraphName("host")]
		public MediaHost Host { get; set; }
		
		/// <summary>
		/// Globally unique identifier.
		/// </summary>
		[GraphName("id")]
		public string Id { get; set; }
		
		/// <summary>
		/// The media content type.
		/// </summary>
		[GraphName("mediaContentType")]
		public MediaContentType MediaContentType { get; set; }
		
		/// <summary>
		/// Any errors which have occurred on the media.
		/// </summary>
		[GraphName("mediaErrors")]
		public List<MediaError> MediaErrors { get; set; }

		/// <summary>
		/// The original source for a 3d model.
		/// </summary>
		[GraphName("originalSource")]
		public VideoSource OriginalSource { get; set; }

		/// <summary>
		/// The preview image for the media.
		/// </summary>
		[GraphName("preview")]
		public MediaPreviewImage Preview { get; set; }
		
		/// <summary>
		/// The sources for a 3d model.
		/// </summary>
		[GraphName("originalSource")]
		public List<VideoSource> Sources { get; set; }
		
		/// <summary>
		/// Current status of the media.
		/// </summary>
		[GraphName("status")]
		public MediaStatus Status { get; set; }
	}
}