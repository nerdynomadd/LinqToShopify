using LinqToGraphQL.Attributes;
using LinqToShopify.GraphQL.Admin.Context.Types.Interface;

namespace LinqToShopify.GraphQL.Admin.Context.Types
{
    public class WebhookHttpEndpoint: WebhookSubscriptionEndpoint
    {
        [GraphName("callbackUrl")]
        public string CallbackUrl { get; set; }
    }
}