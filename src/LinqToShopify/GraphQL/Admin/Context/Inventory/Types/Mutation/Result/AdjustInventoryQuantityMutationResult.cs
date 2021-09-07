using LinqToGraphQL.Attributes;

namespace LinqToShopify.GraphQL.Admin.Context.Inventory.Types.Mutation.Result
{
	public class AdjustInventoryQuantityMutationResult
	{
		/// <summary>
		/// The newly activated inventory level.
		/// </summary>
		[GraphName("inventoryLevel")]
		public InventoryLevel InventoryLevel { get; set; }
	}
}