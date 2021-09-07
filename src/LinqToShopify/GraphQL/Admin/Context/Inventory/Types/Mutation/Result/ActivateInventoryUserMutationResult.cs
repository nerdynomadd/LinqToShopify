using LinqToGraphQL.Attributes;
using LinqToShopify.GraphQL.Admin.Context.Common.Types.Mutation.Result;

namespace LinqToShopify.GraphQL.Admin.Context.Inventory.Types.Mutation.Result
{
	public class ActivateInventoryUserMutationResult : UserMutationResult
	{
		/// <summary>
		/// The newly activated inventory level.
		/// </summary>
		[GraphName("inventoryLevel")]
		public InventoryLevel InventoryLevel { get; set; }
	}
}