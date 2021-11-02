using LinqToGraphQL.Attributes;
using LinqToShopify.GraphQL.Admin.Context.Metafield.Types.Enum;

namespace LinqToShopify.GraphQL.Admin.Context.Metafield.Types.Inputs
{
	/// <summary>
	/// Value Input wraps two fields of Private Metafields into one. Those fields are value and value_type.
	/// </summary>
	public class PrivateMetafieldValueInput
	{
		/// <summary>
		/// The value of a private metafield.
		/// </summary>
		[GraphName("value")]
		public string Value { get; set; }
		
		/// <summary>
		/// Represents the private metafield value type.
		/// </summary>
		[GraphName("valueType")]
		public PrivateMetafieldValueType ValueType { get; set; }
	}
}