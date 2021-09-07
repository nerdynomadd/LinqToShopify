using LinqToGraphQL.Attributes;

namespace LinqToShopify.GraphQL.Admin.Context.Global.NavigationItem
{
	public class NavigationItem : Node.Node, INavigationItem
	{
		
		/// <summary>
		/// The name of the navigation item.
		/// </summary>
		[GraphName("title")]
		public string Title { get; set; }
		
		/// <summary>
		/// The URL of the page that the navigation item links to.
		/// </summary>
		[GraphName("url")]
		public string Url { get; set; }
		
	}
}