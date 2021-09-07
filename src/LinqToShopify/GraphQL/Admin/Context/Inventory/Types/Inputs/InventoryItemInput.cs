using LinqToGraphQL.Attributes;
using LinqToGraphQL.Translator.Behavior;

namespace LinqToShopify.GraphQL.Admin.Context.Inventory.Types.Inputs
{
	public class InventoryItemInput
	{
		/// <summary>
		/// Unit cost associated with the inventory item, the currency is the shop's default currency.
		/// </summary>
		[GraphNameBehavior(TranslatorBehavior.CamelCase)]
		public decimal Cost { get; set; }
		
		/// <summary>
		/// Whether the inventory item is tracked.
		/// </summary>
		[GraphNameBehavior(TranslatorBehavior.CamelCase)]
		public bool Tracked { get; set; }
	}
}