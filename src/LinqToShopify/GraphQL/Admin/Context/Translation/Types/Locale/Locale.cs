using LinqToGraphQL.Attributes;

namespace LinqToShopify.GraphQL.Admin.Context.Translation.Types.Locale
{
	public class Locale
	{
		[GraphName("isoCode")]
		public string IsoCode { get; set; }
		
		[GraphName("name")]
		public string Name { get; set; }
	}
}