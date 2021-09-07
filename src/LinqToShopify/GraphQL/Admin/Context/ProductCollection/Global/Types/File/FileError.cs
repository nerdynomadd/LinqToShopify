using LinqToShopify.GraphQL.Admin.Context.ProductCollection.Global.Types.File.Enum;

namespace LinqToShopify.GraphQL.Admin.Context.ProductCollection.Global.Types.File
{
	/// <summary>
	/// A file error.
	/// </summary>
	public class FileError
	{
		/// <summary>
		/// Code representing the type of error.
		/// </summary>
		public FileErrorCode Code { get; set; }
		
		/// <summary>
		/// Additional details regarding the error.
		/// </summary>
		public string Details { get; set; }
		
		/// <summary>
		/// The error types for a file.
		/// </summary>
		public string Message { get; set; }
	}
}