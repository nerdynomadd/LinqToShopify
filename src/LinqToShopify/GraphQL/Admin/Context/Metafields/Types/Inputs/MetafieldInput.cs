using LinqToGraphQL.Attributes;

namespace LinqToShopify.GraphQL.Admin.Context.Metafield.Types.Inputs
{
	public class MetafieldInput
	{
		/// <summary>
		/// The unique ID of the metafield.
		/// </summary>
		[GraphName("id")]
		public string Id { get; set; }
		
		/// <summary>
		/// The description of the metafield.
		/// </summary>
		[GraphName("description")]
		public string Description { get; set; }
		
		/// <summary>
		/// The namespace for a metafield.
		/// </summary>
		[GraphName("key")]
		public string Key { get; set; }
		
		/// <summary>
		/// The namespace for a metafield.
		/// </summary>
		[GraphName("namespace")]
		public string Namespace { get; set; }
		
		/// <summary>
		/// The type name of the metafield.
		/// </summary>
		[GraphName("type")]
		public string Type { get; set; }
		
		/// <summary>
		/// The value of a metafield.
		/// </summary>
		[GraphName("value")]
		public string Value { get; set; }
	}
}