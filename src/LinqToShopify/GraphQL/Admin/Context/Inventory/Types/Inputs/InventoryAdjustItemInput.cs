namespace LinqToShopify.GraphQL.Admin.Context.Inventory.Types.Inputs
{
	public class InventoryAdjustItemInput
	{
		/// <summary>
		/// Count by which to adjust the available quantity.
		/// </summary>
		public int AvailableDelta { get; set; }
		
		/// <summary>
		/// ID of the inventory item to adjust.
		/// </summary>
		public int InventoryItemId { get; set; }
	}
}