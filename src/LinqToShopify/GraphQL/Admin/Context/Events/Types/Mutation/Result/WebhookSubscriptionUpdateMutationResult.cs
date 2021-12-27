using System.Collections.Generic;
using LinqToGraphQL.Attributes;
using LinqToShopify.GraphQL.Admin.Context.Common.Types.Mutation.Error;

namespace LinqToShopify.GraphQL.Admin.Context.Types.Mutation
{
    public class WebhookSubscriptionUpdateMutationResult
    {
        [GraphName("userErrors")]
        public List<UserError> UserErrors { get; set; }
        [GraphName("webhookSubscription")]
        public WebhookSubscription WebhookSubscription { get; set; }
    }
}