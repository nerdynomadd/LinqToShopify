using System.Collections.Generic;
using LinqToGraphQL.Attributes;
using LinqToShopify.GraphQL.Admin.Context.Common.Types.Image;
using LinqToShopify.GraphQL.Admin.Context.Global.Node;

namespace LinqToShopify.GraphQL.Admin.Context.App.Types.App
{
	/// <summary>
	/// A Shopify application.
	/// </summary>
	public class App : Node
	{
		/// <summary>
		/// Name of the app.
		/// </summary>
		[GraphName("title")]
		public string Title { get; set; }
		
		/// <summary>
		/// A unique application API identifier.
		/// </summary>
		[GraphName("apiKey")]
		public string ApiKey { get; set; }
		
		/// <summary>
		/// App store page URL of the app.
		/// </summary>
		[GraphName("appStoreAppUrl")]
		public string? AppStoreAppUrl { get; set; }
		
		/// <summary>
		/// App store page URL of the developer who created the app.
		/// </summary>
		[GraphName("appStoreDeveloperUrl")]
		public string? AppStoreDeveloperUrl { get; set; }
		
		/// <summary>
		/// Banner image for the app.
		/// </summary>
		[GraphName("banner")]
		public Image Banner { get; set; }
		
		/// <summary>
		/// Description of the app.
		/// </summary>
		[GraphName("description")]
		public string? Description { get; set; }
		
		/// <summary>
		/// App's developer name.
		/// </summary>
		[GraphName("developerName")]
		public string? DeveloperName { get; set; }
		
		/// <summary>
		/// Whether the app uses the Embedded App SDK.
		/// </summary>
		[GraphName("embedded")]
		public bool Embedded { get; set; }
		
		/// <summary>
		/// Requirements that must be met before the app can be installed.
		/// </summary>
		[GraphName("failedRequirements")]
		public List<AppFailedRequirement> FailedRequirements { get; set; }
		
		/// <summary>
		/// List of app features.
		/// </summary>
		[GraphName("features")]
		public List<string> Features { get; set; }

		/// <summary>
		/// Feedback from this app about the store.
		/// </summary>
		[GraphName("feedback")]
		public AppFeedback.AppFeedback? Feedback { get; set; }
		
		/// <summary>
		/// Handle of the app.
		/// </summary>
		[GraphName("handle")]
		public string? Handle { get; set; }
		
		/// <summary>
		/// Icon that represents the app.
		/// </summary>
		[GraphName("icon")]
		public Image Icon { get; set; }
		
		/// <summary>
		/// Webpage where you can install the app.
		/// </summary>
		[GraphName("installUrl")]
		public string? InstallUrl { get; set; }
		
		/// <summary>
		/// Corresponding AppInstallation for this shop and App. Returns null if the App is not installed.
		/// </summary>
		[GraphName("installation")]
		public AppInstallation.AppInstallation? Installation { get; set; }
		
		/// <summary>
		/// Detailed information about the app pricing.
		/// </summary>
		[GraphName("pricingDetails")]
		public string? PricingDetails { get; set; }
		
		/// <summary>
		/// Summary of the app pricing details.
		/// </summary>
		[GraphName("pricingDetailsSummary")]
		public string PricingDetailsSummary { get; set; }
		
		/// <summary>
		/// Link to app privacy policy.
		/// </summary>
		[GraphName("privacyPolicyUrl")]
		public string? PrivacyPolicyUrl { get; set; }
		
		/// <summary>
		/// Wheter the app is published
		/// </summary>
		[GraphName("published")]
		public bool Published { get; set; }
		
		/// <summary>
		/// Screenshots of the app.
		/// </summary>
		[GraphName("screenshots")]
		public List<Image> Screenshots { get; set; }
		
		/// <summary>
		/// Whether the app was developed by Shopify.
		/// </summary>
		[GraphName("shopifyDeveloped")]
		public bool ShopifyDeveloped { get; set; }
		
		/// <summary>
		/// Message that appears when the app is uninstalled. For example: By removing this app, you will no longer be able to publish products to MySocialSite or view this app in your Shopify admin. You can re-enable this channel at any time.
		/// </summary>
		[GraphName("uninstallMessage")]
		public string UninstallMessage { get; set; }

	}
}