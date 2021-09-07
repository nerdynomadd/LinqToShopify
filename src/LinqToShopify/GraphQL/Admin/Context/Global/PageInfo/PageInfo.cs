using Newtonsoft.Json;

namespace LinqToShopify.GraphQL.Admin.Context.Global.PageInfo
{
	public class PageInfo
	{
		
		[JsonProperty("hasNextPage")]
		public bool HasNextPage { get; set; }
		
		[JsonProperty("hasPreviousPage")]
		public bool HasPreviousPage { get; set; }
		
	}
}