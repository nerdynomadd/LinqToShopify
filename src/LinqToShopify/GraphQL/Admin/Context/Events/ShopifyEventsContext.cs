using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using LinqToGraphQL.Attributes;
using LinqToGraphQL.Context.Options.Builder.Configure;
using LinqToGraphQL.Set;
using LinqToGraphQL.Set.Configuration;
using LinqToGraphQL.Set.Configuration.Builder;
using LinqToShopify.GraphQL.Admin.Context.Common.Types.Id;
using LinqToShopify.GraphQL.Admin.Context.Connections;
using LinqToShopify.GraphQL.Admin.Context.Types;
using LinqToShopify.GraphQL.Admin.Context.Types.Enum;
using LinqToShopify.GraphQL.Admin.Context.Types.Inputs;
using LinqToShopify.GraphQL.Admin.Context.Types.Mutation;

namespace LinqToShopify.GraphQL.Admin.Context
{
    public class ShopifyEventsContext : ShopifyBaseContext
    {
        public ShopifyEventsContext(string myShopifyName, string authorization) : base(new Dictionary<string, object>
        {
            ["MyShopifyName"] = myShopifyName,
            ["Authorization"] = authorization
        })
        {
        }

        /* QUERIES */
        
        #region QUERIES definition

        [GraphName("deletionEvents")]
        public GraphSet<WebhookSubscriptionConnection> GetDeletionEvents(string after = null,
            string before = null,
            string callbackUrl = null,
            int? first = null,
            WebhookSubscriptionFormat format = WebhookSubscriptionFormat.JSON,
            int? last = null,
            string query = null,
            bool reverse = false,
            DeletionEventSortKeys sortKey = DeletionEventSortKeys.ID,
            List<DeletionEventSubjectType> subjectTypes = null)
        {
            return Set<WebhookSubscriptionConnection>(new object[]
            {
                after, before, callbackUrl, first, format, last, query, reverse, sortKey, subjectTypes
            });
        }

        [GraphName("webhookSubscription")]
        public GraphSet<WebhookSubscription> GetWebhookSubscription(
            [GraphNonNullableParameter] [GraphParameterType(typeof(ID))]
            string id)
        {
            return Set<WebhookSubscription>(new object[]
            {
                id
            });
        }

        [GraphName("webhookSubscriptions")]
        public GraphSet<WebhookSubscriptionConnection> GetWebhookSubscriptions(string after = null,
            string before = null,
            string callbackUrl = null,
            int? first = null,
            WebhookSubscriptionFormat format = WebhookSubscriptionFormat.JSON,
            int? last = null,
            string query = null,
            bool reverse = false,
            WebhookSubscriptionSortKeys sortKey = WebhookSubscriptionSortKeys.ID,
            List<WebhookSubscriptionTopic> topics = null)
        {
            return Set<WebhookSubscriptionConnection>(new object[]
            {
                after, before, callbackUrl, first, format, last, query, reverse, sortKey, topics
            });
        }

        #endregion

        /* MUTATIONS */
        
        #region Mutations definition

        [GraphName("webhookSubscriptionCreate")]
        public GraphSet<WebhookSubscriptionCreateMutationResult> CreateWebhookSubscription(
            [GraphNonNullableParameter] WebhookSubscriptionTopic input,
            [GraphNonNullableParameter] WebhookSubscriptionInput webhookSubscription)
        {
            return Set<WebhookSubscriptionCreateMutationResult>(new object[]
                {
                    input,
                    webhookSubscription
                },
                builder =>
                {
                    builder.ConfigureQuery(queryBuilder => { queryBuilder.WithType(GraphSetTypes.Mutation); });
                });
        }

        [GraphName("webhookSubscriptionDelete")]
        public GraphSet<WebhookSubscriptionDeleteMutationResult> DeleteWebhookSubscription(
            [GraphNonNullableParameter] [GraphParameterType(typeof(ID))]
            string id)
        {
            return Set<WebhookSubscriptionDeleteMutationResult>(new object[]
                {
                    id
                },
                builder =>
                {
                    builder.ConfigureQuery(queryBuilder => { queryBuilder.WithType(GraphSetTypes.Mutation); });
                });
        }

        [GraphName("webhookSubscriptionUpdate")]
        public GraphSet<WebhookSubscriptionUpdateMutationResult> UpdateWebhookSubscription(
            [GraphNonNullableParameter] [GraphParameterType(typeof(ID))]
            string id, [GraphNonNullableParameter] WebhookSubscriptionInput webhookSubscription)
        {
            return Set<WebhookSubscriptionUpdateMutationResult>(new object[]
                {
                    id,
                    webhookSubscription
                },
                builder =>
                {
                    builder.ConfigureQuery(queryBuilder => { queryBuilder.WithType(GraphSetTypes.Mutation); });
                });
        }
        
        #endregion

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
			
            graphContextConfigureOptionsBuilder.ConfigureSet<WebhookSubscriptionConnection>(graphSetConfigurationBuilder);
			
            graphContextConfigureOptionsBuilder.ConfigureSet<WebhookSubscription>(graphSetConfigurationBuilder);		
			
            graphContextConfigureOptionsBuilder.ConfigureSet<WebhookSubscriptionCreateMutationResult>(graphSetConfigurationBuilder);		
            
            graphContextConfigureOptionsBuilder.ConfigureSet<WebhookSubscriptionDeleteMutationResult>(graphSetConfigurationBuilder);

            graphContextConfigureOptionsBuilder.ConfigureSet<WebhookSubscriptionUpdateMutationResult>(graphSetConfigurationBuilder);
			
        }
    }

}