using LinqToGraphQL.Attributes;

namespace LinqToShopify.GraphQL.Admin.Context.ProductCollection.Global.Types.Move.Input
{
	public class MoveInput
	{
		[GraphName("id")]
		public string Id { get; set; }
		
		[GraphName("newPosition")]
		public ulong NewPosition { get; set; }
	}
}