using LinqToGraphQL.Attributes;
using LinqToGraphQL.Translator.Behavior;

namespace LinqToShopify.GraphQL.Admin.Context.Inventory.Types.Inputs
{
	public class InventoryLevelInput
	{
		/// <summary>
		/// Sets the quantity available at the location.
		/// </summary>
		[GraphNameBehavior(TranslatorBehavior.CamelCase)]
		public int AvailableQuantity { get; set; }
		
		/// <summary>
		/// ID of the location.
		/// </summary>
		[GraphNameBehavior(TranslatorBehavior.CamelCase)]
		public string LocationId { get; set; }
	}
}