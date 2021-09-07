using LinqToGraphQL.Attributes;
using LinqToShopify.GraphQL.Admin.Context.Global.Node;

namespace LinqToShopify.GraphQL.Admin.Context.Global.NavigationItem
{
	public interface INavigationItem : INode
	{
		/// <summary>
		/// The name of the navigation item.
		/// </summary>
		[GraphName("title")]
		public string Title { get; set; }
		
		/// <summary>
		/// The URL of the page that the navigation item links to.s
		/// </summary>
		[GraphName("url")]
		public string Url { get; set; }
	}
}