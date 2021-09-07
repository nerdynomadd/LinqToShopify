using LinqToShopify.GraphQL.Admin.Context.ProductCollection.Global.Types.File.Node;

namespace LinqToShopify.GraphQL.Admin.Context.ProductCollection.Global.Types.File
{
	/// <summary>
	/// A generic file.
	/// </summary>
	public class GenericFile : FileNode
	{
		/// <summary>
		/// The URL of the file
		/// </summary>
		public string Url { get; set; }
	}
}