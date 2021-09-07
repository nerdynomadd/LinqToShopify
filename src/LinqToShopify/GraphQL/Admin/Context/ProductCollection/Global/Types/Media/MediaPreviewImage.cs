using LinqToGraphQL.Attributes;
using LinqToShopify.GraphQL.Admin.Context.Common.Types.Image;
using LinqToShopify.GraphQL.Admin.Context.ProductCollection.Global.Types.Media.Enum;

namespace LinqToShopify.GraphQL.Admin.Context.ProductCollection.Global.Types.Media
{
	/// <summary>
	/// Represents the preview image for a media.
	/// </summary>
	public class MediaPreviewImage
	{
		/// <summary>
		/// The preview image for the media.
		/// </summary>
		[GraphName("image")]
		public Image Image { get; set; }
		
		/// <summary>
		/// The possible statuses for a media preview image.
		/// </summary>
		[GraphName("status")]
		public MediaPreviewImageStatus Status { get; set; }
	}
}