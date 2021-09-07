using System;
using LinqToGraphQL.Attributes;
using LinqToShopify.GraphQL.Admin.Context.Common.Types.MoneyV2;
using LinqToShopify.GraphQL.Admin.Context.Global.Node;

namespace LinqToShopify.GraphQL.Admin.Context.Billing.Types.AppCredit
{
	public class AppCredit : Node
	{
		[GraphName("amount")]
		public MoneyV2 Amount { get; set; }
		
		[GraphName("createdAt")]
		public DateTime CreatedAt { get; set; }
		
		[GraphName("description")]
		public string Description { get; set; }
		
		[GraphName("test")]
		public bool Test { get; set; }
	}
}