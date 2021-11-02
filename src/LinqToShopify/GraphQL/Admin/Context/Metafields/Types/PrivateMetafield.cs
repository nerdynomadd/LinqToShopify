using System;
using LinqToGraphQL.Attributes;
using LinqToShopify.GraphQL.Admin.Context.Global.Node;
using LinqToShopify.GraphQL.Admin.Context.Metafield.Types.Enum;

namespace LinqToShopify.GraphQL.Admin.Context.Metafield.Types
{
	public class PrivateMetafield : Node
	{
		[GraphName("key")]
		public string Key { get; set; }
		
		[GraphName("value")]
		public string Value { get; set; }

		[GraphName("namespace")]
		public string Namespace { get; set; }
		
		[GraphName("valueType")]
		public PrivateMetafieldValueType ValueType { get; set; }

		[GraphName("createdAt")]
		public DateTime CreatedAt { get; set; }
		
		[GraphName("updatedAt")]
		public DateTime UpdatedAt { get; set; }
	}
}