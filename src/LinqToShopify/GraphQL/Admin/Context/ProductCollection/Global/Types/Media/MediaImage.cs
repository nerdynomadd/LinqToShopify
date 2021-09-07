using System;
using System.Collections.Generic;
using LinqToGraphQL.Attributes;
using LinqToShopify.GraphQL.Admin.Context.Common.Types.Image;
using LinqToShopify.GraphQL.Admin.Context.Global.Node;
using LinqToShopify.GraphQL.Admin.Context.ProductCollection.Global.Types.File;
using LinqToShopify.GraphQL.Admin.Context.ProductCollection.Global.Types.File.Enum;
using LinqToShopify.GraphQL.Admin.Context.ProductCollection.Global.Types.File.Interface;
using LinqToShopify.GraphQL.Admin.Context.ProductCollection.Global.Types.Media.Enum;
using LinqToShopify.GraphQL.Admin.Context.ProductCollection.Global.Types.Media.Interface;

namespace LinqToShopify.GraphQL.Admin.Context.ProductCollection.Global.Types.Media
{
	/// <summary>
	/// Represents a Shopify hosted image.
	/// </summary>
	public class MediaImage : IFile, INode, IMedia
	{
		/// <summary>
		/// A word or phrase to describe the contents or the function of a file.
		/// </summary>
		[GraphName("alt")]
		public string Alt { get; set; }
		
		/// <summary>
		/// The date and time (ISO 8601 format) when the product was created.
		/// </summary>
		[GraphName("alt")]
		public DateTime CreatedAt { get; set; }
		
		/// <summary>
		/// Any errors that have occurred on the file.
		/// </summary>
		[GraphName("fileErrors")]
		public List<FileError> FileErrors { get; set; }
		
		/// <summary>
		/// Code representing the type of error.
		/// </summary>
		[GraphName("fileStatus")]
		public FileStatus FileStatus { get; set; }
		
		/// <summary>
		/// Globally unique identifier.
		/// </summary>
		[GraphName("id")]
		public string Id { get; set; }
		
		/// <summary>
		/// The image for the media.
		/// </summary>
		[GraphName("image")]
		public Image Image { get; set; }
		
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
		/// The MIME type of the image.
		/// </summary>
		[GraphName("mimeType")]
		public string MimeType { get; set; }
		
		/// <summary>
		/// Code representing the type of error.
		/// </summary>
		[GraphName("preview")]
		public MediaPreviewImage Preview { get; set; }	
		
		/// <summary>
		/// Current status of the media.
		/// </summary>
		[GraphName("status")]
		public MediaStatus Status { get; set; }
	}
}