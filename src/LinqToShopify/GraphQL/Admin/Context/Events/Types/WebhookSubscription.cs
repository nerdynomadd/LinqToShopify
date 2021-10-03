using System;
using LinqToGraphQL.Attributes;
using LinqToShopify.GraphQL.Admin.Context.Types.Enum;

namespace LinqToShopify.GraphQL.Admin.Context.Types
{
    public class WebhookSubscription
    {
        [GraphName("createdAt")]
        private DateTime createdAt { get; set; }
        
        [GraphName("createdAt")]
        private WebhookHttpEndpoint endpoint { get; set; }
        
        [GraphName("format")]
        private WebhookSubscriptionFormat format  { get; set; }
        
        [GraphName("id")]
        private string id { get; set; }
        
        [GraphName("includeFields")]
        private string[] includeFields { get; set; }
        
        [GraphName("legacyResourceId")]
        private ulong legacyResourceId { get; set; }
        
        [GraphName("metafieldNamespaces")]
        private string[] metafieldNamespaces { get; set; }
        
        [GraphName("topic")]
        private WebhookSubscriptionTopic topic { get; set; }
        
        [GraphName("updatedAt")]
        private DateTime updatedAt { get; set; }
    }
}