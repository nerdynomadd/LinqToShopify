using System;
using System.Collections.Generic;
using LinqToGraphQL.Attributes;
using LinqToShopify.GraphQL.Admin.Context.Types.Enum;

namespace LinqToShopify.GraphQL.Admin.Context.Types
{
    public class WebhookSubscription
    {
        [GraphName("createdAt")]
        public DateTime CreatedAt { get; set; }
        
        [GraphName("endpoint")]
        public WebhookHttpEndpoint Endpoint { get; set; }
        
        [GraphName("format")]
        public WebhookSubscriptionFormat Format  { get; set; }
        
        [GraphName("id")]
        public string id { get; set; }
        
        [GraphName("includeFields")]
        public List<string> IncludeFields { get; set; }
        
        [GraphName("legacyResourceId")]
        public ulong LegacyResourceId { get; set; }
        
        [GraphName("metafieldNamespaces")]
        public List<string> MetafieldNamespaces { get; set; }
        
        [GraphName("topic")]
        public WebhookSubscriptionTopic Topic { get; set; }
        
        [GraphName("updatedAt")]
        public DateTime UpdatedAt { get; set; }
    }
}