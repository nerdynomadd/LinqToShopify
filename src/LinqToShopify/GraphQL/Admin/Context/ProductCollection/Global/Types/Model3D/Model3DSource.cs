using LinqToGraphQL.Attributes;

namespace LinqToShopify.GraphQL.Admin.Context.ProductCollection.Global.Types.Model3D
{
	/// <summary>
	/// Represents a source for a Shopify hosted 3d model.
	/// </summary>
	public class Model3DSource
	{
		/// <summary>
		/// The filesize of the 3d model.
		/// </summary>
		[GraphName("filesize")]
		public int Filesize { get; set; }
		
		/// <summary>
		/// The format of the 3d model.
		/// </summary>
		[GraphName("format")]
		public string Format { get; set; }
		
		/// <summary>
		/// The MIME type of the 3d model.
		/// </summary>
		[GraphName("mimeType")]
		public string MimeType { get; set; }
		
		/// <summary>
		/// The URL of the 3d model.
		/// </summary>
		[GraphName("url")]
		public string Url { get; set; }
	}
}