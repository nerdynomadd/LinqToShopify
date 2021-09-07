using System;
using LinqToGraphQL.Attributes;
using LinqToGraphQL.Attributes.Method;
using LinqToShopify.GraphQL.Admin.Context.Common.Types.CountryCode;
using LinqToShopify.GraphQL.Admin.Context.Common.Types.Id;
using LinqToShopify.GraphQL.Admin.Context.Common.Types.MoneyV2;
using LinqToShopify.GraphQL.Admin.Context.Global.LegacyInteroperability;
using LinqToShopify.GraphQL.Admin.Context.Global.Node;
using LinqToShopify.GraphQL.Admin.Context.Inventory.Connection;
using LinqToShopify.GraphQL.Admin.Context.ProductCollection.Types.Product.Variant;
using LinqToShopify.GraphQL.Admin.Context.ShippingFulfillment.Types;

namespace LinqToShopify.GraphQL.Admin.Context.Inventory.Types
{
	/// <summary>
	/// Represents the goods available to be shipped to a customer. It holds essential information about the goods, including SKU and whether it is tracked.
	/// </summary>
	public class InventoryItem : Node, ILegacyInteroperability
	{
		private CountryHarmonizedSystemCodeConnection _countryHarmonizedSystemCodes;

		/// <summary>
		/// List of country specific harmonized system codes.
		/// </summary>
		/// <param name="after">Returns the elements that come after the specified cursor.</param>
		/// <param name="before">Returns the elements that come before the specified cursor.</param>
		/// <param name="first">Returns up to the first n elements from the list.</param>
		/// <param name="last">Returns up to the last n elements from the list.</param>
		/// <param name="reverse">Reverse the order of the underlying list.</param>
		/// <returns></returns>
		[GraphName("countryHarmonizedSystemCodes")]
		[GraphBackingField(nameof(_countryHarmonizedSystemCodes))]
		public CountryHarmonizedSystemCodeConnection CountryHarmonizedSystemCodes(string after = null,
			string before = null,
			int? first = null,
			int? last = null,
			bool reverse = false) => _countryHarmonizedSystemCodes;

		private InventoryLevelConnection _inventoryLevels;

		/// <param name="after">Returns the elements that come after the specified cursor.</param>
		/// <param name="before">Returns the elements that come before the specified cursor.</param>
		/// <param name="first">Returns up to the first n elements from the list.</param>
		/// <param name="last">Returns up to the last n elements from the list.</param>
		/// <param name="query"></param>
		/// <param name="reverse">Reverse the order of the underlying list.</param>
		/// <returns></returns>
		[GraphName("inventoryLevels")]
		[GraphBackingField(nameof(_inventoryLevels))]
		public InventoryLevelConnection InventoryLevels(string after = null,
			string before = null,
			int? first = null,
			int? last = null,
			string query = null,
			bool reverse = false) => _inventoryLevels;
		
		/// <summary>
		/// The ISO code of the country of origin.
		/// </summary>
		[GraphName("countryCodeOfOrigin")]
		public CountryCode CountryCodeOfOrigin { get; set; }
		
		/// <summary>
		/// The date and time when the inventory item was created.
		/// </summary>
		[GraphName("createdAt")]
		public DateTime CreatedAt { get; set; }
		
		/// <summary>
		/// The number of inventory items that share the same SKU with this item.
		/// </summary>
		[GraphName("duplicateSkuCount")]
		public int DuplicateSkuCount { get; set; }
		
		/// <summary>
		/// The harmonized system code of the item.
		/// </summary>
		[GraphName("harmonizedSystemCode")]
		public string HarmonizedSystemCode { get; set; }
		
		/// <summary>
		/// URL for inventory history web page.
		/// </summary>
		[GraphName("inventoryHistoryUrl")]
		public string InventoryHistoryUrl { get; set; }

		private InventoryLevel _inventoryLevel;

		/// <summary>
		/// Get the inventory level at a specific location.
		/// </summary>
		/// <param name="locationId">ID of the location for which the inventory level is requested.</param>
		/// <returns></returns>
		[GraphName("inventoryLevel")]
		[GraphBackingField(nameof(_inventoryLevel))]
		public InventoryLevel InventoryLevel([GraphNonNullableParameter] [GraphParameterType(typeof(ID))] int locationId) => _inventoryLevel;
		
		/// <summary>
		/// The ID of the corresponding resource in the REST Admin API.
		/// </summary>
		[GraphName("legacyResourceId")]
		public ulong LegacyResourceId { get; set; }
		
		/// <summary>
		/// The number of locations where this inventory item is stocked.
		/// </summary>
		[GraphName("locationsCount")]
		public int LocationsCount { get; set; }
		
		/// <summary>
		/// The ISO code of the province of origin.
		/// </summary>
		[GraphName("provinceCodeOfOrigin")]
		public string ProvinceCodeOfOrigin { get; set; }
		
		/// <summary>
		/// Whether the item requires shipping or not.
		/// </summary>
		[GraphName("requiresShipping")]
		public bool RequiresShipping { get; set; }
		
		/// <summary>
		/// Inventory item SKU.
		/// </summary>
		[GraphName("sku")]
		public string Sku { get; set; }
		
		/// <summary>
		/// Whether the inventory quantities of inventory levels for the item are tracked or not.
		/// </summary>
		[GraphName("tracked")]
		public bool Tracked { get; set; }
		
		/// <summary>
		/// Whether changes to the inventory item tracked attribute are allowed.
		/// </summary>
		[GraphName("trackedEditable")]
		public EditableProperty TrackedEditable { get; set; }
		
		/// <summary>
		/// Unit cost associated with the inventory item.
		/// </summary>
		[GraphName("unitCost")]
		public MoneyV2 UnitCost { get; set; }
		
		/// <summary>
		/// The date and time when the inventory item was updated.
		/// </summary>
		[GraphName("updatedAt")]
		public DateTime UpdatedAt { get; set; }
		
		/// <summary>
		/// The variant that owns this inventory item.
		/// </summary>
		[GraphName("variant")]
		public ProductVariant Variant { get; set; }
	}
}