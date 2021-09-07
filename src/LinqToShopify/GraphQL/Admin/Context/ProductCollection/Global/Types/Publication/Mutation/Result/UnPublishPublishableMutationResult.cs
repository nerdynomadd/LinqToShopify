using LinqToGraphQL.Attributes;
using LinqToShopify.GraphQL.Admin.Context.Common.Types.Mutation.Result;
using LinqToShopify.GraphQL.Admin.Context.Store.Types.Shop;

namespace LinqToShopify.GraphQL.Admin.Context.ProductCollection.Global.Types.Publication.Mutation
{
	public class UnPublishPublishableMutationResult : UserMutationResult
	{
		/// <summary>
		/// Resource that has been published.
		/// </summary>
		[GraphName("publishable")]
		public Publishable.Publishable Publishable { get; set; }
		
		/// <summary>
		/// The user's shop.
		/// </summary>
		[GraphName("shop")]
		public Shop Shop { get; set; }
	}
}