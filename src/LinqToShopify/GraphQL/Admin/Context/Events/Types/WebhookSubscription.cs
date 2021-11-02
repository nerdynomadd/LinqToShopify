using System;
using System.Collections.Generic;
using LinqToGraphQL.Attributes;
using LinqToShopify.GraphQL.Admin.Context.Types.Enum;

namespace LinqToShopify.GraphQL.Admin.Context.Types
{
    public class WebhookSubscription
    {
        [GraphName("createdAt")]
        private DateTime CreatedAt { get; set; }
        
        [GraphName("endpoint")]
        private WebhookHttpEndpoint Endpoint { get; set; }
        
        [GraphName("format")]
        private WebhookSubscriptionFormat Format  { get; set; }
        
        [GraphName("id")]
        private string id { get; set; }
        
        [GraphName("includeFields")]
        private List<string> IncludeFields { get; set; }
        
        [GraphName("legacyResourceId")]
        private ulong LegacyResourceId { get; set; }
        
        [GraphName("metafieldNamespaces")]
        private List<string> MetafieldNamespaces { get; set; }
        
        [GraphName("topic")]
        private WebhookSubscriptionTopic Topic { get; set; }
        
        [GraphName("updatedAt")]
        private DateTime UpdatedAt { get; set; }
    }
}