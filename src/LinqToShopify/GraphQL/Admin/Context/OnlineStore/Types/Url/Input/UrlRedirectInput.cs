using LinqToGraphQL.Attributes;

namespace LinqToShopify.GraphQL.Admin.Context.OnlineStore.Types.Url.Input
{
	public class UrlRedirectInput
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