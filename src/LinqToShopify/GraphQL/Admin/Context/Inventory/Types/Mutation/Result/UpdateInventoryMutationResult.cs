using LinqToGraphQL.Attributes;

namespace LinqToShopify.GraphQL.Admin.Context.Inventory.Types.Mutation.Result
{
	public class UpdateInventoryMutationResult
	{
		/// <summary>
		/// The updated inventory item.
		/// </summary>
		[GraphName("inventoryItem")]
		public InventoryItem InventoryItem { get; set; }
	}
}