using LinqToGraphQL.Attributes;
using LinqToShopify.GraphQL.Admin.Context.OnlineStore.Types.Script.Enum;

namespace LinqToShopify.GraphQL.Admin.Context.OnlineStore.Types.Script.Input
{
	public class ScriptTagInput
	{
		/// <summary>
		/// Whether the Shopify CDN can cache and serve the script tag. If true, then the script will be cached and served by the CDN. The cache expires 15 minutes after the script tag is successfully returned. If false, then the script will be served as is.
		/// </summary>
		[GraphName("cache")]
		public bool Cache { get; set; }
		
		/// <summary>
		/// The page or pages on the online store where the script should be included.
		/// </summary>
		[GraphName("displayScope")]
		public ScriptTagDisplayScope DisplayScope { get; set; }
		
		/// <summary>
		/// The URL of the remote script.
		/// </summary>
		[GraphName("url")]
		public string Url { get; set; }
	}
}