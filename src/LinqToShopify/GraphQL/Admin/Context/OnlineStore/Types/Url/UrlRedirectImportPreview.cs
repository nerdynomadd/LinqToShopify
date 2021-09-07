using LinqToGraphQL.Attributes;

namespace LinqToShopify.GraphQL.Admin.Context.OnlineStore.Types.Url
{
	/// <summary>
	/// A preview of a URL redirect import row.
	/// </summary>
	public class UrlRedirectImportPreview
	{
		/// <summary>
		/// The old path to be redirected. When the user visits this path, they will be redirected to the target.
		/// </summary>
		[GraphName("path")]
		public string Path { get; set; }
		
		/// <summary>
		/// The target location where the user will be redirected.
		/// </summary>
		[GraphName("target")]
		public string Target { get; set; }
	}
}