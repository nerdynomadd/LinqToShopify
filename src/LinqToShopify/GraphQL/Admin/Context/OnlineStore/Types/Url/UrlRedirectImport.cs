using System.Collections.Generic;
using LinqToGraphQL.Attributes;
using LinqToShopify.GraphQL.Admin.Context.Global.Node;

namespace LinqToShopify.GraphQL.Admin.Context.OnlineStore.Types.Url
{
	/// <summary>
	/// A request to import redirects into the Online Store.
	/// </summary>
	public class UrlRedirectImport : Node
	{
		/// <summary>
		/// The number of rows in the file.
		/// </summary>
		[GraphName("count")]
		public int Count { get; set; }
		
		/// <summary>
		/// The number of redirects created from this import.
		/// </summary>
		[GraphName("createdCount")]
		public int CreatedCount { get; set; }
		
		/// <summary>
		/// The number of redirects that failed to be imported from this import.
		/// </summary>
		[GraphName("failedCount")]
		public int FailedCount { get; set; }
		
		/// <summary>
		/// The number of redirects updated during this import.
		/// </summary>
		[GraphName("updatedCount")]
		public int UpdatedCount { get; set; }
		
		/// <summary>
		/// Whether the import is finished.
		/// </summary>
		[GraphName("finished")]
		public bool Finished { get; set; }
		
		/// <summary>
		/// Up to 3 previews of the URL redirects that will be imported.
		/// </summary>
		[GraphName("previewRedirects")]
		public List<UrlRedirectImportPreview> PreviewRedirects { get; set; }
	}
}