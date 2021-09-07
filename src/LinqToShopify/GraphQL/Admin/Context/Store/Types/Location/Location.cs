using System;
using System.Collections.Generic;
using LinqToGraphQL.Attributes;
using LinqToShopify.GraphQL.Admin.Context.Common.Types.Id;
using LinqToShopify.GraphQL.Admin.Context.Global.LegacyInteroperability;
using LinqToShopify.GraphQL.Admin.Context.Global.Node;
using LinqToShopify.GraphQL.Admin.Context.Inventory.Types;
using LinqToShopify.GraphQL.Admin.Context.ShippingFulfillment.Types.Fulfillment;

namespace LinqToShopify.GraphQL.Admin.Context.Store.Types.Location
{
	/// <summary>
	/// Represents the location where the physical good resides.
	/// </summary>
	public class Location : Node, ILegacyInteroperability
	{
		/// <summary>
		/// Whether this location can be reactivated.
		/// </summary>
		[GraphName("activatable")]
		public bool Activatable { get; set; }
		
		/// <summary>
		/// The LocationAddress object for location.
		/// </summary>
		[GraphName("address")]
		public LocationAddress Address { get; set; }
		
		/// <summary>
		/// Whether the location address has been verified.
		/// </summary>
		[GraphName("addressVerified")]
		public bool AddressVerified { get; set; }
		
		/// <summary>
		/// Whether this location can be deactivated.
		/// </summary>
		[GraphName("deactivatable")]
		public bool Deactivatable { get; set; }
		
		/// <summary>
		/// Date and time the location was deactivated (null if location is still active). Following UTC ISO8601 format, e.g.: "2019-04-24T13:42:24Z".
		/// </summary>
		[GraphName("deactivatedAt")]
		public DateTime DeactivatedAt { get; set; }
		
		/// <summary>
		/// Name of the service provider that fulfills from this location.
		/// </summary>
		[GraphName("fulfillmentService")]
		public FulfillmentService FulfillmentService { get; set; }
		
		/// <summary>
		/// Name of the service provider that fulfills from this location.
		/// </summary>
		[GraphName("fulfillsOnlineOrders")]
		public bool FulfillsOnlineOrders { get; set; }
		
		/// <summary>
		/// Indicates whether or not this location has active inventory.
		/// </summary>
		[GraphName("hasActiveInventory")]
		public bool HasActiveInventory { get; set; }
		
		/// <summary>
		/// Indicates whether or not this location has unfulfilled orders.
		/// </summary>
		[GraphName("hasUnfulfilledOrders")]
		public bool HasUnfulfilledOrders { get; set; }
		
		private InventoryLevel _inventoryLevel;

		/// <summary>
		/// A single inventory level for the given inventory item.
		/// </summary>
		/// <param name="inventoryItemId">Specifies the inventory item ID for the inventory level to be returned.</param>
		/// <returns></returns>
		[GraphName("inventoryLevel")]
		public InventoryLevel InventoryLevel([GraphNonNullableParameter] [GraphParameterType(typeof(ID))] int inventoryItemId) => _inventoryLevel;

		/// <summary>
		/// Whether the location is active.
		/// </summary>
		[GraphName("isActive")]
		public bool IsActive { get; set; }
		
		/// <summary>
		/// The ID of the corresponding resource in the REST Admin API.
		/// </summary>
		[GraphName("activatable")]
		public ulong LegacyResourceId { get; set; }
		
		/// <summary>
		/// The name of the location.
		/// </summary>
		[GraphName("name")]
		public string Name { get; set; }
		
		/// <summary>
		/// Indicates whether or not this location is used for calculating shipping rates.
		/// </summary>
		[GraphName("shipsInventory")]
		public bool ShipsInventory { get; set; }
		
		/// <summary>
		/// List of suggested addresses for this location (empty if none).
		/// </summary>
		[GraphName("suggestedAddresses")]
		public List<LocationSuggestedAddress> SuggestedAddresses { get; set; }
	}
}