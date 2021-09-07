using System;
using LinqToGraphQL.Attributes;
using LinqToShopify.GraphQL.Admin.Context.Global.Node;
using LinqToShopify.GraphQL.Admin.Context.Store.Types.Location;

namespace LinqToShopify.GraphQL.Admin.Context.Inventory.Types
{
	public class InventoryLevel : Node
	{
		/// <summary>
		/// Quantity of items available at the location.
		/// </summary>
		[GraphName("available")]
		public int Available { get; set; }
		
		/// <summary>
		/// Whether inventoryDeactivate is allowed for this inventory level.
		/// </summary>
		[GraphName("canDeactivate")]
		public bool CanDeactivate { get; set; }
		
		/// <summary>
		/// The date and time when the inventory level was created.
		/// </summary>
		[GraphName("createdAt")]
		public DateTime CreatedAt { get; set; }
		
		/// <summary>
		/// Reason why canDeactivate is false, or impact of deactivating the inventory level.
		/// </summary>
		[GraphName("deactivationAlert")]
		public string DeactivationAlert { get; set; }
		
		/// <summary>
		/// Reason why canDeactivate is false with URLs linked in HTML, or impact of deactivating the inventory level.
		/// </summary>
		[GraphName("deactivationAlertHtml")]
		public string DeactivationAltertHtml { get; set; }
		
		/// <summary>
		/// Quantity of items incoming to the location.
		/// </summary>
		[GraphName("incoming")]
		public int Incoming { get; set; }
		
		/// <summary>
		/// Inventory item associated with the inventory level.
		/// </summary>
		[GraphName("item")]
		public InventoryItem Item { get; set; }
		
		/// <summary>
		/// Location associated with the inventory level.
		/// </summary>
		[GraphName("location")]
		public Location Location { get; set; }
		
		/// <summary>
		/// The date and time when the inventory level was updated.
		/// </summary>
		[GraphName("updatedAt")]
		public DateTime UpdatedAt { get; set; }
	}
}