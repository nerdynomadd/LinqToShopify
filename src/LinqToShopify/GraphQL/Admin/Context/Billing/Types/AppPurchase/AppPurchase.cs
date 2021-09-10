using System;
using LinqToGraphQL.Attributes;
using LinqToShopify.GraphQL.Admin.Context.Billing.Types.AppPurchase.Enum;
using LinqToShopify.GraphQL.Admin.Context.Common.Types.MoneyV2;
using LinqToShopify.GraphQL.Admin.Context.Global.Node;

namespace LinqToShopify.GraphQL.Admin.Context.Billing.Types.AppPurchase
{
	public class AppPurchase : Node
	{
		[GraphName("name")]
		public string Name { get; set; }
		
		[GraphName("createdAt")]
		public DateTime CreatedAt { get; set; }
		
		[GraphName("price")]
		public MoneyV2 Price { get; set; }
		
		[GraphName("status")]
		public AppPurchaseStatus Status { get; set; }
		
		[GraphName("test")]
		public bool Test { get; set; }
	}
}