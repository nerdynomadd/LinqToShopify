using LinqToGraphQL.Attributes;

namespace LinqToShopify.GraphQL.Admin.Context.Inventory.Types.Inputs
{
	public class InventoryAdjustQuantityInput
	{
		
		/// <summary>
		/// Count by which to adjust the available quantity.
		/// </summary>
		[GraphName("availableDelta")]
		public int AvailableDelta { get; set; }
		
		/// <summary>
		/// ID of the inventory level to adjust.
		/// </summary>
		[GraphName("inventoryLevelId")]
		public string InventoryLevelId { get; set; }
		
	}
}