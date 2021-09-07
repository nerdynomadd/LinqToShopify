using System.Collections.Generic;
using LinqToGraphQL.Attributes;
using LinqToShopify.GraphQL.Admin.Context.Global.Edge;

namespace LinqToShopify.GraphQL.Admin.Context.Global.Connection
{
	public class Connection<T>
	{
		
		[GraphName("edges")]
		public List<Edge<T>> Edges { get; set; }
		
		[GraphName("pageInfo")]
		public PageInfo.PageInfo PageInfo { get; set; }
		
	}
}