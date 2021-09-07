using LinqToGraphQL.Attributes;

namespace LinqToShopify.GraphQL.Admin.Context.ProductCollection.Global.Types.File.Input
{
	/// <summary>
	/// The input fields that are required to update a file object.
	/// </summary>
	public class FileUpdateInput
	{
		/// <summary>
		/// The alt text associated with the file.
		/// </summary>
		[GraphName("alt")]
		public string Alt { get; set; } = null;
		
		/// <summary>
		/// The file to update.
		/// </summary>
		[GraphName("id")]
		public string Id { get; set; }
	}
}