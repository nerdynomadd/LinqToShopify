using LinqToShopify.GraphQL.Admin.Context.Global.Node;

namespace LinqToShopify.GraphQL.Admin.Context.OnlineStore.Types.Url
{
	/// <summary>
	/// A redirect on the Online Store.
	/// </summary>
	public class UrlRedirect : Node
	{
		/// <summary>
		/// The old path to be redirected. When the user visits this path, they will be redirected to the target.
		/// </summary>
		public string Path { get; set; }
		
		/// <summary>
		/// The target location where the user will be redirected.
		/// </summary>
		public string Target { get; set; }
	}
}