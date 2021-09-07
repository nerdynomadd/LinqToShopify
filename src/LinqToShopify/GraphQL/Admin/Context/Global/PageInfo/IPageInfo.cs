using Newtonsoft.Json;

namespace LinqToShopify.GraphQL.Admin.Context.Global.PageInfo
{
	public interface IPageInfo
	{
		[JsonProperty("hasNextPage")]
		public bool HasNextPage { get; set; }
		
		[JsonProperty("hasPreviousPage")]
		public bool HasPreviousPage { get; set; }
	}
}