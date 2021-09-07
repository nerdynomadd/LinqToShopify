using LinqToGraphQL.Attributes;

namespace LinqToShopify.GraphQL.Admin.Context.Global.Node
{
	public class Node : INode
	{
		/// <summary>
		/// Globally unique identifier.
		/// </summary>
		[GraphName("id")]
		public string Id { get; set; }
	}
}