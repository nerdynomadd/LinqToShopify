using LinqToGraphQL.Attributes;

namespace LinqToShopify.GraphQL.Admin.Context.Translation.Types.Translation
{
	public class PublishedTranslation
	{
		[GraphName("key")]
		public string Key { get; set; }
		
		[GraphName("locale")]
		public string Locale { get; set; }
		
		[GraphName("value")]
		public string Value { get; set; }
	}
}