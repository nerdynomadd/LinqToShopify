using System.Collections.Generic;
using LinqToGraphQL.Attributes;
using LinqToGraphQL.Set;
using LinqToGraphQL.Set.Configuration;
using LinqToShopify.GraphQL.Admin.Context.Metafield.Types.Inputs;
using LinqToShopify.GraphQL.Admin.Context.Metafield.Types.Mutation.Result;

namespace LinqToShopify.GraphQL.Admin.Context.Metafield
{
	public class ShopifyMetafieldContext : ShopifyBaseContext
	{
		internal ShopifyMetafieldContext(string myShopifyName, string authorization) : base(new Dictionary<string, object>
		{
			["MyShopifyName"] = myShopifyName,
			["Authorization"] = authorization
		})
		{
		}

		[GraphName("metafieldDelete")]
		public GraphSet<DeleteMetafieldUserMutationResult> DeleteMetafield([GraphParameterTypeName("MetafieldDeleteInput")] DeleteMetafieldInput input)
		{
			return Set<DeleteMetafieldUserMutationResult>(new object[]
			{
				input
			}, builder =>
			{
				builder.ConfigureQuery(queryBuilder =>
				{
					queryBuilder.WithType(GraphSetTypes.Mutation);
				});
			});
		}
	}
}