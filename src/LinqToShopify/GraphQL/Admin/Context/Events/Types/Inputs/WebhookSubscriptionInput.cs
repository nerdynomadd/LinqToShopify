using System.Collections.Generic;
using LinqToGraphQL.Attributes;
using LinqToShopify.GraphQL.Admin.Context.Types.Enum;

namespace LinqToShopify.GraphQL.Admin.Context.Types.Inputs
{
    public class WebhookSubscriptionInput
    {
        [GraphName("callbackUrl")]
        public string CallbackUrl { get; set; }

        [GraphName("format")]
        private WebhookSubscriptionFormat Format { get; set; }
        
        [GraphName("includeFields")] 
        private List<string> IncludeFields { get; set; }

        [GraphName("metafieldNamespaces")]
        private List<string> MetafieldNamespaces { get; set; }
    }
}