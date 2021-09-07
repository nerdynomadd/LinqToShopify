using LinqToGraphQL.Attributes;
using LinqToShopify.GraphQL.Admin.Context.Billing.Connections;
using LinqToShopify.GraphQL.Admin.Context.Billing.Types.AppRecord.Query.Input;
using LinqToShopify.GraphQL.Admin.Context.Billing.Types.Global.AppPlan;
using LinqToShopify.GraphQL.Admin.Context.Global.Node;

namespace LinqToShopify.GraphQL.Admin.Context.Billing.Types.Global.AppSubscription
{
	public class AppSubscriptionLineItem : Node
	{
		[GraphName("usageRecords")]
		public AppUsageRecordConnection UsageRecords(string after, 
			string before, 
			int first, 
			int last,
			bool reverse,
			AppUsageRecordSortKeys sortKey) => new AppUsageRecordConnection();
		
		[GraphName("plan")]
		public AppPlanV2 Plan { get; set; }
	}
}