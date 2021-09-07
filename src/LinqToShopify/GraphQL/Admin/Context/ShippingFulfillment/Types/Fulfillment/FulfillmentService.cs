using System.Collections.Generic;
using LinqToShopify.GraphQL.Admin.Context.ShippingFulfillment.Types.Fulfillment.Enum;
using LinqToShopify.GraphQL.Admin.Context.ShippingFulfillment.Types.Shipping;
using LinqToShopify.GraphQL.Admin.Context.Store.Types.Location;

namespace LinqToShopify.GraphQL.Admin.Context.ShippingFulfillment.Types.Fulfillment
{
	/// <summary>
	/// Represents a fulfillment service. A fulfillment service is a third-party service that prepares and ships orders on behalf of the store owner.
	/// </summary>
	public class FulfillmentService
	{
		/// <summary>
		/// The callback URL the fulfillment service has registered for requests.
		/// </summary>
		public string CallbackUrl { get; set; }
		
		/// <summary>
		/// Whether the fulfillment service has opted into fulfillment order based requests.
		/// </summary>
		public bool FulfillmentOrdersOptIn { get; set; }
		
		/// <summary>
		/// Human-readable unique identifier for this fulfillment service.
		/// </summary>
		public string Handle { get; set; }
		
		/// <summary>
		/// The ID of the fulfillment service.
		/// </summary>
		public string Id { get; set; }
		
		/// <summary>
		/// Whether the fulfillment service tracks product inventory and provides updates to Shopify.
		/// </summary>
		public bool InventoryManagement { get; set; }
		
		/// <summary>
		/// Location associated with the fulfillment service.
		/// </summary>
		public Location Location { get; set; }
		
		/// <summary>
		/// Whether the fulfillment service supports local deliveries.
		/// </summary>
		public bool ProductBased { get; set; }
		
		/// <summary>
		/// The name of the fulfillment service as seen by merchants.
		/// </summary>
		public string ServiceName { get; set; }
		
		/// <summary>
		/// Shipping methods associated with the fulfillment service provider.
		/// </summary>
		public List<ShippingMethod> ShippingMethods { get; set; }
		
		/// <summary>
		/// Type associated with the fulfillment service.
		/// </summary>
		public FulfillmentServiceType Type { get; set; }
	}
}