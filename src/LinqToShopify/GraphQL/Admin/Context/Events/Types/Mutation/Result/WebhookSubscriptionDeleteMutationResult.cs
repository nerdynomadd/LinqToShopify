using System.Collections.Generic;
using LinqToGraphQL.Attributes;
using LinqToShopify.GraphQL.Admin.Context.Common.Types.Mutation.Error;

namespace LinqToShopify.GraphQL.Admin.Context.Types.Mutation
{
    public class WebhookSubscriptionDeleteMutationResult
    {
        [GraphName("userErrors")]
        public List<UserError> UserErrors { get; set; }
        [GraphName("deletedWebhookSubscriptionId")]
        private string DeletedWebhookSubscriptionId { get; set; }
    }
}