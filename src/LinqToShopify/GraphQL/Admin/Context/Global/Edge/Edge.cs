using LinqToGraphQL.Attributes;

namespace LinqToShopify.GraphQL.Admin.Context.Global.Edge
{
	public class Edge<T>
	{
		
		[GraphName("node")]
		public T Node { get; set; }
		
		[GraphName("cursor")]
		public string Cursor { get; set; }

	}
}