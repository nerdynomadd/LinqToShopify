using LinqToGraphQL.Attributes;
using LinqToShopify.GraphQL.Admin.Context.Common.Types.Mutation.Result;

namespace LinqToShopify.GraphQL.Admin.Context.Translation.Types.Locale.Mutation.Result
{
	public class UpdateShopLocaleUserMutationResult : UserMutationResult
	{
		[GraphName("shopLocale")]
		public ShopLocale ShopLocale { get; set; }
	}
}