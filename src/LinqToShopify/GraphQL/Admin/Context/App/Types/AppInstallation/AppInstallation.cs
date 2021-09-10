using System.Collections.Generic;
using LinqToGraphQL.Attributes;
using LinqToGraphQL.Attributes.Method;
using LinqToShopify.GraphQL.Admin.Context.Billing.Connections;
using LinqToShopify.GraphQL.Admin.Context.Billing.Types.AppSubscription;
using LinqToShopify.GraphQL.Admin.Context.Billing.Types.AppSubscription.Input;
using LinqToShopify.GraphQL.Admin.Context.Billing.Types.Global.AppTransaction.Enum;
using LinqToShopify.GraphQL.Admin.Context.Common.Types.AccessScope;
using LinqToShopify.GraphQL.Admin.Context.Global.Node;

namespace LinqToShopify.GraphQL.Admin.Context.App.Types.AppInstallation
{
	public class AppInstallation : Node
	{
		private AppSubscriptionConnection _allSubscriptions;

		/// <summary>
		/// All subscriptions created for a shop.
		/// </summary>
		/// <param name="after"></param>
		/// <param name="before"></param>
		/// <param name="first"></param>
		/// <param name="last"></param>
		/// <param name="reverse"></param>
		/// <param name="sortKey"></param>
		/// <returns></returns>
		[GraphName("allSubscriptions")]
		[GraphBackingField(nameof(_allSubscriptions))]
		public AppSubscriptionConnection AllSubscriptions(string? after, string? before, int? first, int? last, bool? reverse, AppSubscriptionSortKeys sortKey) => _allSubscriptions;
		
		private AppCreditConnection _credits;

		/// <summary>
		/// Credits that can be used towards future app purchases.
		/// </summary>
		/// <param name="after"></param>
		/// <param name="before"></param>
		/// <param name="first"></param>
		/// <param name="last"></param>
		/// <param name="reverse"></param>
		/// <param name="sortKey"></param>
		/// <returns></returns>
		[GraphName("credits")]
		[GraphBackingField(nameof(_credits))]
		public AppCreditConnection Credits(string? after, string? before, int? first, int? last, bool? reverse, AppTransactionSortKeys sortKey) => _credits;

		private AppPurchaseOneTimeConnection _oneTimePurchases;

		/// <summary>
		/// One-time purchases to a shop.
		/// </summary>
		/// <param name="after"></param>
		/// <param name="before"></param>
		/// <param name="first"></param>
		/// <param name="last"></param>
		/// <param name="reverse"></param>
		/// <param name="sortKey"></param>
		/// <returns></returns>
		[GraphName("oneTimePurchases")]
		[GraphBackingField(nameof(_oneTimePurchases))]
		public AppPurchaseOneTimeConnection OneTimePurchases(string? after, string? before, int? first, int? last, bool? reverse, AppTransactionSortKeys sortKey) => _oneTimePurchases;

		/// <summary>
		/// Application which is installed.
		/// </summary>
		[GraphName("app")]
		public App.App App { get; set; }
		
		/// <summary>
		/// Access scopes granted to an app by a merchant during installation.
		/// </summary>
		[GraphName("accessScopes")]
		public List<AccessScope> AccessScopes { get; set; }
		
		/// <summary>
		/// Active subscriptions charged to a shop on a recurring basis.
		/// </summary>
		[GraphName("activeSubscriptions")]
		public List<AppSubscription> ActiveSubscriptions { get; set; }
		
		/// <summary>
		/// Publication associated with the installed application.
		/// </summary>
		[GraphName("publication")]
		public Publication.Publication Publication { get; set; }
		
		/// <summary>
		/// Url used to launch the app.
		/// </summary>
		[GraphName("launchUrl")]
		public string LaunchUrl { get; set; }
		
		/// <summary>
		/// Webpage where you can uninstall the app.
		/// </summary>
		[GraphName("uninstallUrl")]
		public string UninstallUrl { get; set; }
	}
}