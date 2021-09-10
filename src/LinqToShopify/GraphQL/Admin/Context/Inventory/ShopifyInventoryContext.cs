using System.Collections.Generic;
using LinqToGraphQL.Attributes;
using LinqToGraphQL.Set;
using LinqToGraphQL.Set.Configuration;
using LinqToShopify.GraphQL.Admin.Context.Common.Types.Id;
using LinqToShopify.GraphQL.Admin.Context.Inventory.Types;
using LinqToShopify.GraphQL.Admin.Context.Inventory.Types.Inputs;
using LinqToShopify.GraphQL.Admin.Context.Inventory.Types.Mutation.Result;

namespace LinqToShopify.GraphQL.Admin.Context.Inventory
{
	public class ShopifyInventoryContext : ShopifyBaseContext
	{
		internal ShopifyInventoryContext(string myShopifyName, string authorization) : base(new Dictionary<string, object>
		{
			["MyShopifyName"] = myShopifyName,
			["Authorization"] = authorization
		})
		{
		}

		/// <summary>
		/// Returns an InventoryItem resource by ID.
		/// </summary>
		/// <param name="id">The ID of the InventoryItem to return.</param>
		/// <returns></returns>
		[GraphName("inventoryItem")]
		public GraphSet<InventoryItem> GetInventoryItem([GraphNonNullableParameter] [GraphParameterType(typeof(ID))] string id = null)
		{
			return Set<InventoryItem>(new object[]
			{
				id
			});
		}
		
		/// <summary>
		/// List of inventory items.
		/// </summary>
		/// <param name="after">Returns the elements that come after the specified cursor.</param>
		/// <param name="before">Returns the elements that come before the specified cursor.</param>
		/// <param name="first">Returns up to the first n elements from the list.</param>
		/// <param name="last">Returns up to the last n elements from the list.</param>
		/// <param name="query"></param>
		/// <param name="reverse">Reverse the order of the underlying list.</param>
		/// <returns></returns>
		[GraphName("inventoryItems")]
		public GraphSet<InventoryItem> GetInventoryItems(string after = null,
			string before = null,
			int? first = null,
			int? last = null,
			string query = null,
			bool reverse = false)
		{
			return Set<InventoryItem>(new object[]
			{
				after,
				before,
				first,
				last,
				query,
				reverse
			});
		}
		
		/// <summary>
		/// Returns an InventoryLevel resource by ID.
		/// </summary>
		/// <param name="id">The ID of the InventoryLevel to return.</param>
		/// <returns></returns>
		[GraphName("inventoryLevel")]
		public GraphSet<InventoryLevel> GetInventoryLevel([GraphNonNullableParameter] [GraphParameterType(typeof(ID))] string id = null)
		{
			return Set<InventoryLevel>(new object[]
			{
				id
			});
		}

		/// <summary>
		/// Activate an inventory item at a location.
		/// https://shopify.dev/api/admin/graphql/reference/inventory/inventoryactivate
		/// </summary>
		/// <param name="inventoryItemId">Specifies which item should be activated.</param>
		/// <param name="locationId">Specifies where the item should be activated.</param>
		/// <param name="available">The initial available quantity at the location.</param>
		/// <returns></returns>
		[GraphName("inventoryActivate")]
		public GraphSet<ActivateInventoryUserMutationResult> ActivateInventory([GraphNonNullableParameter] [GraphParameterType(typeof(ID))] string inventoryItemId,
			[GraphNonNullableParameter] [GraphParameterType(typeof(ID))] string locationId,
			int? available = null)
		{
			return Set<ActivateInventoryUserMutationResult>(new object[]
			{
				inventoryItemId, locationId, available
			}, builder =>
			{
				builder.ConfigureQuery(queryBuilder =>
				{
					queryBuilder.WithType(GraphSetTypes.Mutation);
				});
			});
		}
		
		/// <summary>
		/// Deactivate an inventory item at a location.
		/// https://shopify.dev/api/admin/graphql/reference/inventory/inventorydeactivate
		/// </summary>
		/// <param name="inventoryLevelId">Specifies which inventory level should be deactivated.</param>
		/// <returns></returns>
		[GraphName("inventoryDeactivate")]
		public GraphSet<DeactivateInventoryUserMutationResult> DeactivateInventory([GraphNonNullableParameter] [GraphParameterType(typeof(ID))] string inventoryLevelId)
		{
			return Set<DeactivateInventoryUserMutationResult>(new object[]
			{
				inventoryLevelId
			}, builder =>
			{
				builder.ConfigureQuery(queryBuilder =>
				{
					queryBuilder.WithType(GraphSetTypes.Mutation);
				});
			});
		}
		
		/// <summary>
		/// Adjusts the inventory by a certain quantity.
		/// https://shopify.dev/api/admin/graphql/reference/inventory/inventoryadjustquantity
		/// </summary>
		/// <param name="input">Provides the input fields required to update an inventory level.</param>
		/// <returns></returns>
		[GraphName("inventoryDeactivate")]
		public GraphSet<AdjustInventoryQuantityMutationResult> AdjustInventoryQuantity([GraphNonNullableParameter] AdjustInventoryQuantityMutationResult input)
		{
			return Set<AdjustInventoryQuantityMutationResult>(new object[]
			{
				input
			}, builder =>
			{
				builder.ConfigureQuery(queryBuilder =>
				{
					queryBuilder.WithType(GraphSetTypes.Mutation);
				});
			});
		}
		
		/// <summary>
		/// Updates an inventory item.
		/// https://shopify.dev/api/admin/graphql/reference/inventory/inventoryitemupdate
		/// </summary>
		/// <param name="input">Provides the input fields required to update an inventory level.</param>
		/// <returns></returns>
		[GraphName("inventoryItemUpdate")]
		public GraphSet<UpdateInventoryMutationResult> UpdateInventoryItem([GraphNonNullableParameter] [GraphParameterType(typeof(ID))] string id, 
			[GraphNonNullableParameter] InventoryItemUpdateInput input)
		{
			return Set<UpdateInventoryMutationResult>(new object[]
			{
				id, input
			}, builder =>
			{
				builder.ConfigureQuery(queryBuilder =>
				{
					queryBuilder.WithType(GraphSetTypes.Mutation);
				});
			});
		}
		
		/// <summary>
		/// Updates an inventory item.
		/// https://shopify.dev/api/admin/graphql/reference/inventory/inventoryitemupdate
		/// </summary>
		/// <param name="input">Provides the input fields required to update an inventory level.</param>
		/// <returns></returns>
		[GraphName("inventoryBulkAdjustQuantityAtLocation")]
		public GraphSet<UpdateInventoryMutationResult> BulkAdjustInventoryQuantityAtLocation([GraphNonNullableParameter] [GraphParameterType(typeof(ID))] string id, 
			[GraphNonNullableParameter] InventoryItemUpdateInput input)
		{
			return Set<UpdateInventoryMutationResult>(new object[]
			{
				id, input
			}, builder =>
			{
				builder.ConfigureQuery(queryBuilder =>
				{
					queryBuilder.WithType(GraphSetTypes.Mutation);
				});
			});
		}
	}
}