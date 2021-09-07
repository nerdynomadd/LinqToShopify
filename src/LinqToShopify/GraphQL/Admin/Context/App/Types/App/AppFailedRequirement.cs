using LinqToGraphQL.Attributes;
using LinqToShopify.GraphQL.Admin.Context.Global.NavigationItem;

namespace LinqToShopify.GraphQL.Admin.Context.App.Types.App
{
	/// <summary>
	/// Requirements that must be met before an app can be installed.
	/// </summary>
	public class AppFailedRequirement
	{
		/// <summary>
		/// Action to be taken to resolve a failed requirement, including URL link.
		/// </summary>
		[GraphName("action")]
		public NavigationItem Action { get; set; }
		
		/// <summary>
		/// A concise set of copy strings to be displayed to merchants, to guide them in resolving problems your app encounters when trying to make use of their Shop and its resources.
		/// </summary>
		[GraphName("message")]
		public string Message { get; set; }
	}
}