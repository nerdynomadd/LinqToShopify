using LinqToGraphQL.Attributes;

namespace LinqToShopify.GraphQL.Admin.Context.Metafield.Types.Inputs
{
	/// <summary>
	/// Specifies the input fields for a PrivateMetafield.
	/// </summary>
	public class PrivateMetafieldInput
	{
		/// <summary>
		/// The owning resource.
		/// </summary>
		[GraphName("owner")]
		public string Owner { get; set; }

		/// <summary>
		/// The key for the private metafield.
		/// </summary>
		[GraphName("key")]
		public string Key { get; set; }
		
		/// <summary>
		/// The namespace for the private metafield.
		/// </summary>
		[GraphName("namespace")]
		public string Namespace { get; set; }

		/// <summary>
		/// The value and value type of the metafield, wrapped in a ValueInput object.
		/// </summary>
		[GraphName("valueInput")]
		public PrivateMetafieldValueInput ValueInput { get; set; }
	}
}