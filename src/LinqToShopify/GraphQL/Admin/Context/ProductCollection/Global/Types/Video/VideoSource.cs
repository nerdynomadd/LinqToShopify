namespace LinqToShopify.GraphQL.Admin.Context.ProductCollection.Global.Types.Video
{
	/// <summary>
	/// Represents a source for a Shopify hosted video.
	/// </summary>
	public class VideoSource
	{
		/// <summary>
		/// The format of the video source.
		/// </summary>
		public string Format { get; set; }
		
		/// <summary>
		/// The height of the video.
		/// </summary>
		public int Height { get; set; }
		
		/// <summary>
		/// The video MIME type.
		/// </summary>
		public string MimeType { get; set; }
		
		/// <summary>
		/// The URL of the video.
		/// </summary>
		public string Url { get; set; }
		
		/// <summary>
		/// The width of the video.
		/// </summary>
		public int Width { get; set; }
	}
}