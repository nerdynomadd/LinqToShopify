using System;
using LinqToGraphQL.Attributes;
using LinqToShopify.GraphQL.Admin.Context.Global.Node;
using LinqToShopify.GraphQL.Admin.Context.Metafield.Types.Enum;

namespace LinqToShopify.GraphQL.Admin.Context.Metafield.Types
{
	public class Metafield : Node
	{
		
		[GraphName("description")]
		public string Description { get; set; }
		
		[GraphName("key")]
		public string Key { get; set; }
		
		[GraphName("value")]
		public string Value { get; set; }
		
		[GraphName("legacyResourceId")]
		public ulong LegacyResourceId { get; set; }
		
		[GraphName("namespace")]
		public string Namespace { get; set; }
		
		[GraphName("ownerType")]
		public MetafieldOwnerType OwnerType { get; set; }

		[GraphName("createdAt")]
		public DateTime CreatedAt { get; set; }
		
		[GraphName("updatedAt")]
		public DateTime UpdatedAt { get; set; }
		
	}
}