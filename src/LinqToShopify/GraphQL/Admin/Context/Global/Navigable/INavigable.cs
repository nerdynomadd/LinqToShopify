using LinqToGraphQL.Attributes;

namespace LinqToShopify.GraphQL.Admin.Context.Global.Navigable
{
	/// <summary>
	/// A default cursor that you can use in queries to paginate your results. Each edge in a connection can return a cursor, which is a reference to the edge's position in the connection. You can use an edge's cursor as the starting point to retrieve the nodes before or after it in a connection.
	/// </summary>
	public interface INavigable
	{
		/// <summary>
		/// A default cursor that returns the single next record, sorted ascending by ID.
		/// </summary>
		[GraphName("defaultCursor")]
		public string DefaultCursor { get; set; }
	}
}