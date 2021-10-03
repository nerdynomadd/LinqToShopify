using System.Collections.Generic;
using LinqToGraphQL.Attributes;
using LinqToGraphQL.Set;
using LinqToGraphQL.Set.Configuration;
using LinqToShopify.GraphQL.Admin.Context.Metafield.Types.Inputs;
using LinqToShopify.GraphQL.Admin.Context.Metafield.Types.Mutation.Result;

namespace LinqToShopify.GraphQL.Admin.Context
{
    public class ShopifyEventsContext: ShopifyBaseContext
    {
        public ShopifyEventsContext(string myShopifyName, string authorization) : base(new Dictionary<string, object>
        {
            ["MyShopifyName"] = myShopifyName,
            ["Authorization"] = authorization
        })
        {
        }
    }
}