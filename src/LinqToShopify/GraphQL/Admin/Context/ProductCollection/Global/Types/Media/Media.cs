using System.Collections.Generic;
using LinqToGraphQL.Attributes;
using LinqToShopify.GraphQL.Admin.Context.ProductCollection.Global.Types.Media.Enum;
using LinqToShopify.GraphQL.Admin.Context.ProductCollection.Global.Types.Media.Interface;

namespace LinqToShopify.GraphQL.Admin.Context.ProductCollection.Global.Types.Media
{
	/// <summary>
	/// An auto-generated type for paginating through multiple Media.
	/// </summary>
	public class Media : IMedia
	{
		/// <summary>
		/// A word or phrase to share the nature or contents of a media.
		/// </summary>
		[GraphName("alt")]
		public string Alt { get; set; }
		
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
		/// The preview image for the media.
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