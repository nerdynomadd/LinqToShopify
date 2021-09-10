using System;
using System.Collections.Generic;
using LinqToGraphQL.Attributes;
using LinqToShopify.GraphQL.Admin.Context.Billing.Types.AppSubscription.Enum;
using LinqToShopify.GraphQL.Admin.Context.Global.Node;

namespace LinqToShopify.GraphQL.Admin.Context.Billing.Types.AppSubscription
{
	public class AppSubscription : Node
	{
		[GraphName("createdAt")]
		public DateTime CreatedAt { get; set; }
		
		[GraphName("currentPeriodEnd")]
		public DateTime CurrentPeriodEnd { get; set; }
		
		[GraphName("name")]
		public string Name { get; set; }
		
		[GraphName("lineItems")]
		public List<AppSubscriptionLineItem> LineItems { get; set; }

		[GraphName("returnUrl")]
		public string ReturnUrl { get; set; }
		
		[GraphName("status")]
		public AppSubscriptionStatus Status { get; set; }
		
		[GraphName("trialDays")]
		public int TrialDays { get; set; }
		
		[GraphName("test")]
		public bool Test { get; set; }
	}
}