using LinqToGraphQL.Attributes;

namespace LinqToShopify.GraphQL.Admin.Context.Common.Types.AccessScope
{
	public class AccessScope
	{
		[GraphName("description")]
		public string Description { get; set; }
		
		[GraphName("handle")]
		public string Handle { get; set; }
	}
}