using LinqToGraphQL.Attributes;

namespace LinqToShopify.GraphQL.Admin.Context.Global.Node
{
	/// <summary>
	/// An object with an ID to support global identification.
	/// </summary>
	public interface INode
	{
		/// <summary>
		/// Globally unique identifier.
		/// </summary>
		[GraphName("id")]
		public string Id { get; set; }
	}
}