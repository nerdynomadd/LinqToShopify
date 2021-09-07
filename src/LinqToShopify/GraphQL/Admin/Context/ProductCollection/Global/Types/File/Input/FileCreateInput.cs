using LinqToShopify.GraphQL.Admin.Context.ProductCollection.Global.Types.File.Enum;

namespace LinqToShopify.GraphQL.Admin.Context.ProductCollection.Global.Types.File.Input
{
	/// <summary>
	/// The input fields that are required to create a file object.
	/// </summary>
	public class FileCreateInput
	{
		/// <summary>
		/// The alt text associated with the file.
		/// </summary>
		public string Alt { get; set; }
		
		/// <summary>
		/// The file content type.
		/// </summary>
		public FileContentType ContentType { get; set; }
		
		/// <summary>
		/// An external URL or a signed upload URL of the file object.
		/// </summary>
		public string OriginalSource { get; set; }
	}
}