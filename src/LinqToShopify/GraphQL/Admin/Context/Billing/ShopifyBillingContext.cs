using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using LinqToGraphQL.Attributes;
using LinqToGraphQL.Context.Options.Builder.Configure;
using LinqToGraphQL.Set;
using LinqToGraphQL.Set.Configuration;
using LinqToGraphQL.Set.Configuration.Builder;
using LinqToShopify.GraphQL.Admin.Context.Billing.Types.AppCredit.Mutation.Result;
using LinqToShopify.GraphQL.Admin.Context.Billing.Types.AppPurchase.OneTime.Mutation.Result;
using LinqToShopify.GraphQL.Admin.Context.Billing.Types.AppSubscription.Input;
using LinqToShopify.GraphQL.Admin.Context.Billing.Types.AppSubscription.Mutation.Result;
using LinqToShopify.GraphQL.Admin.Context.Common.Types.Id;
using LinqToShopify.GraphQL.Admin.Context.Common.Types.Money.Input;

namespace LinqToShopify.GraphQL.Admin.Context.Billing
{
	public class ShopifyBillingContext : ShopifyBaseContext
	{
		internal ShopifyBillingContext(string myShopifyName, string authorization) : base(new Dictionary<string, object>
		{
			["MyShopifyName"] = myShopifyName,
			["Authorization"] = authorization
		})
		{
		}
		
		// TODO: Implement usage records
		// TODO: Implement revenue attribution

		/// <summary>
		/// Allows an app to create a credit for a shop that can be used towards future app purchases.
		/// https://shopify.dev/api/admin/graphql/reference/billing/appcreditcreate
		/// </summary>
		/// <param name="description"></param>
		/// <param name="amount"></param>
		/// <param name="test"></param>
		/// <returns></returns>
		[GraphName("appCreditCreate")]
		public GraphSet<AppCreditCreateUserMutationResult> CreateAppCredit([GraphNonNullableParameter] string description, 
			[GraphNonNullableParameter] MoneyInput amount,
			bool test)
		{
			return Set<AppCreditCreateUserMutationResult>(new object[]
			{
				description,
				amount,
				test
			}, builder =>
			{
				builder.ConfigureQuery(queryBuilder =>
				{
					queryBuilder.WithType(GraphSetTypes.Mutation);
				});
			});
		}

		/// <summary>
		/// Allows an app to charge a shop for features or services one time.
		/// https://shopify.dev/api/admin/graphql/reference/billing/apppurchaseonetimecreate
		/// </summary>
		/// <param name="name"></param>
		/// <param name="price"></param>
		/// <param name="returnUrl"></param>
		/// <param name="test"></param>
		/// <returns></returns>
		[GraphName("appPurchaseOneTimeCreate")]
		public GraphSet<AppPurchaseOneTimeCreateUserMutationResult> CreateAppPurchaseOneTime([GraphNonNullableParameter] string name,
			[GraphNonNullableParameter] MoneyInput price,
			[GraphNonNullableParameter] string returnUrl,
			bool test)
		{
			return Set<AppPurchaseOneTimeCreateUserMutationResult>(new object[]
			{
				name,
				price,
				returnUrl,
				test
			}, builder =>
			{
				builder.ConfigureQuery(queryBuilder =>
				{
					queryBuilder.WithType(GraphSetTypes.Mutation);
				});
			});
		}

		/// <summary>
		/// Allows an app to charge a store for features or services on a recurring basis.
		/// https://shopify.dev/api/admin/graphql/reference/billing/appsubscriptioncreate
		/// </summary>
		/// <param name="name"></param>
		/// <param name="returnUrl"></param>
		/// <param name="lineItems"></param>
		/// <param name="trialDays"></param>
		/// <param name="test"></param>
		/// <returns></returns>
		[GraphName("appSubscriptionCreate")]
		public GraphSet<AppSubscriptionCreateUserMutationResult> CreateAppSubscription([GraphNonNullableParameter] string name,
			[GraphNonNullableParameter] string returnUrl,
			[GraphNonNullableParameter] [GraphName("[AppSubscriptionLineItemInput!]")] List<AppSubscriptionLineItemInput> lineItems,
			int? trialDays = null,
			bool test = false)
		{
			return Set<AppSubscriptionCreateUserMutationResult>(new object[]
			{
				name,
				returnUrl,
				lineItems,
				trialDays,
				test
			}, builder =>
			{
				builder.ConfigureQuery(queryBuilder =>
				{
					queryBuilder.WithType(GraphSetTypes.Mutation);
				});
			});
		}
		
		/// <summary>
		/// Cancels an app subscription on a store.
		/// https://shopify.dev/api/admin/graphql/reference/billing/appsubscriptioncancel
		/// </summary>
		/// <param name="id">The ID of the app subscription to be cancelled.</param>
		/// <returns></returns>
		[GraphName("appSubscriptionCancel")]
		public GraphSet<AppSubscriptionCancelUserMutationResult> CancelAppSubscription([GraphNonNullableParameter] [GraphParameterType(typeof(ID))] string id)
		{
			return Set<AppSubscriptionCancelUserMutationResult>(new object[]
			{
				id
			}, builder =>
			{
				builder.ConfigureQuery(queryBuilder =>
				{
					queryBuilder.WithType(GraphSetTypes.Mutation);
				});
			});
		}
		
		/// <summary>
		/// Updates the app plan's pricing details attached to an app subscription.
		/// https://shopify.dev/api/admin/graphql/reference/billing/appsubscriptionlineitemupdate
		/// </summary>
		/// <param name="id">The ID of the app subscription to be cancelled.</param>
		/// <returns></returns>
		[GraphName("appSubscriptionLineItemUpdate")]
		public GraphSet<UpdateSubscriptionLineItemUserMutationResult> UpdateAppSubscriptionLineItem([GraphNonNullableParameter] MoneyInput amount,
			[GraphNonNullableParameter] [GraphParameterType(typeof(ID))] string id)
		{
			return Set<UpdateSubscriptionLineItemUserMutationResult>(new object[]
			{
				amount,
				id
			}, builder =>
			{
				builder.ConfigureQuery(queryBuilder =>
				{
					queryBuilder.WithType(GraphSetTypes.Mutation);
				});
			});
		}

		protected override void Configure(GraphContextConfigureOptionsBuilder graphContextConfigureOptionsBuilder)
		{
			var myShopifyUri = BuildShopUri((string) ContextArguments.First(e => e.Key == "MyShopifyName").Value);

			var authenticationHeaderName = "X-Shopify-Access-Token";
			var authenticationHeaderValue = (string) ContextArguments.First(e => e.Key == "Authorization").Value;

			Action<GraphSetConfigurationBuilder> graphSetConfigurationBuilder = builder =>
			{
				builder.WithUrl(myShopifyUri);

				builder.ConfigureHttp(httpBuilder =>
				{
					httpBuilder.AddHeader(authenticationHeaderName, authenticationHeaderValue);

					httpBuilder.WithMethod(HttpMethod.Post);
				});
			};
			
			graphContextConfigureOptionsBuilder.ConfigureSet<AppCreditCreateUserMutationResult>(graphSetConfigurationBuilder);
			
			graphContextConfigureOptionsBuilder.ConfigureSet<AppPurchaseOneTimeCreateUserMutationResult>(graphSetConfigurationBuilder);		
			
			graphContextConfigureOptionsBuilder.ConfigureSet<AppSubscriptionCreateUserMutationResult>(graphSetConfigurationBuilder);		
			
			graphContextConfigureOptionsBuilder.ConfigureSet<AppSubscriptionCancelUserMutationResult>(graphSetConfigurationBuilder);
			
			graphContextConfigureOptionsBuilder.ConfigureSet<UpdateSubscriptionLineItemUserMutationResult>(graphSetConfigurationBuilder);
		}

	}
}