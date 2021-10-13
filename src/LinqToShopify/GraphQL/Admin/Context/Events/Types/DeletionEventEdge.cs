using LinqToGraphQL.Attributes;

namespace LinqToShopify.GraphQL.Admin.Context.Types
{
    public class DeletionEventEdge
    {
        [GraphName("cursor")]
        public string Cursor { get; set; }
    }
}