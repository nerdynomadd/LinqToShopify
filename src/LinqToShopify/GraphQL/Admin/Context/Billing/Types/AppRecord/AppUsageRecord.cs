using System;
using LinqToGraphQL.Attributes;
using LinqToShopify.GraphQL.Admin.Context.Billing.Types.Global.AppSubscription;
using LinqToShopify.GraphQL.Admin.Context.Common.Types.MoneyV2;
using LinqToShopify.GraphQL.Admin.Context.Global.Node;

namespace LinqToShopify.GraphQL.Admin.Context.Billing.Types.AppRecord
{
	public class AppUsageRecord : Node
	{
		[GraphName("createdAt")]
		public DateTime CreatedAt { get; set; }
		
		[GraphName("description")]
		public string Description { get; set; }
		
		[GraphName("price")]
		public MoneyV2 Price { get; set; }
		
		[GraphName("subscriptionLineItem")]
		public AppSubscriptionLineItem SubscriptionLineItem { get; set; }
	}
}