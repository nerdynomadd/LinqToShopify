using LinqToGraphQL.Attributes;

namespace LinqToShopify.GraphQL.Admin.Context.Translation.Types.Locale.Mutation.Input
{
	public class ShopLocaleInput
	{
		[GraphName("published")]
		public bool Published { get; set; }
	}
}