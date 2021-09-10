using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using LinqToGraphQL.Attributes;
using LinqToGraphQL.Context.Options.Builder.Configure;
using LinqToGraphQL.Set;
using LinqToGraphQL.Set.Configuration;
using LinqToGraphQL.Set.Configuration.Builder;
using LinqToShopify.GraphQL.Admin.Context.Common.Types.Id;
using LinqToShopify.GraphQL.Admin.Context.ProductCollection.Global.Types.Publication.Input;
using LinqToShopify.GraphQL.Admin.Context.ProductCollection.Global.Types.Publication.Mutation;
using LinqToShopify.GraphQL.Admin.Context.ProductCollection.Global.Types.Publication.Mutation.Result;

namespace LinqToShopify.GraphQL.Admin.Context.ProductCollection.Global
{
	public class PublicationBaseContext : ShopifyBaseContext
	{
		public PublicationBaseContext(string myShopifyName, string authorization) : base(new Dictionary<string, object>
		{
			["MyShopifyName"] = myShopifyName,
			["Authorization"] = authorization
		})
		{
		}

		/// <summary>
		/// Publishes a resource to a channel. If the resource is a product, then it's visible in the channel only if the product status is active. Products that are sold exclusively on subscription (requiresSellingPlan: true) can be published only on online stores.
		/// </summary>
		/// <param name="id">The resource to create or update publications for.</param>
		/// <param name="input">Specifies the input fields required to publish a resource.</param>
		/// <returns></returns>
		[GraphName("publishablePublish")]
		public GraphSet<PublishPublishableMutationResult> PublishPublishable([GraphNonNullableParameter] [GraphParameterType(typeof(ID))] string id,
			[GraphNonNullableParameter] [GraphParameterTypeName("[PublicationInput!]")]
			List<PublicationInput> input)
		{
			return Set<PublishPublishableMutationResult>(new object[]
			{
				id, input
			}, builder =>
			{
				builder.ConfigureQuery(queryBuilder =>
				{
					queryBuilder.WithType(GraphSetTypes.Mutation);
				});
			});
		}
		
		/// <summary>
		/// Publishes a resource to current channel. If the resource is a product, then it's visible in the channel only if the product status is active. Products that are sold exclusively on subscription (requiresSellingPlan: true) can be published only on online stores.
		/// </summary>
		/// <param name="id">The resource to create or update publications for.</param>
		/// <returns></returns>
		[GraphName("publishablePublish")]
		public GraphSet<PublishPublishableMutationResult> PublishPublishableToCurrentChannel([GraphNonNullableParameter] [GraphParameterType(typeof(ID))] string id)
		{
			return Set<PublishPublishableMutationResult>(new object[]
			{
				id
			}, builder =>
			{
				builder.ConfigureQuery(queryBuilder =>
				{
					queryBuilder.WithType(GraphSetTypes.Mutation);
				});
			});
		}
		
		/// <summary>
		/// Publishes a resource to a channel. If the resource is a product, then it's visible in the channel only if the product status is active. Products that are sold exclusively on subscription (requiresSellingPlan: true) can be published only on online stores.
		/// </summary>
		/// <param name="id">The resource to delete or update publications for.</param>
		/// <param name="input">Specifies the input fields required to unpublish a resource.</param>
		/// <returns></returns>
		[GraphName("publishableUnpublish")]
		public GraphSet<UnPublishPublishableMutationResult> UnPublishPublishable([GraphNonNullableParameter] [GraphParameterType(typeof(ID))] string id,
			[GraphNonNullableParameter] [GraphParameterTypeName("[PublicationInput!]")]
			List<PublicationInput> input)
		{
			return Set<UnPublishPublishableMutationResult>(new object[]
			{
				id, input
			}, builder =>
			{
				builder.ConfigureQuery(queryBuilder =>
				{
					queryBuilder.WithType(GraphSetTypes.Mutation);
				});
			});
		}


		/// <summary>
		/// Publishes a resource to a channel. If the resource is a product, then it's visible in the channel only if the product status is active. Products that are sold exclusively on subscription (requiresSellingPlan: true) can be published only on online stores.
		/// </summary>
		/// <param name="id">The resource to delete or update publications for.</param>
		/// <returns></returns>
		[GraphName("publishableUnpublishToCurrentChannel")]
		public GraphSet<UnPublishPublishableMutationResult> UnPublishPublishableToCurrentChannel([GraphNonNullableParameter] [GraphParameterType(typeof(ID))] string id)
		{
			return Set<UnPublishPublishableMutationResult>(new object[]
			{
				id
			}, builder =>
			{
				builder.ConfigureQuery(queryBuilder =>
				{
					queryBuilder.WithType(GraphSetTypes.Mutation);
				});
			});
		}
		
		protected override void Configure(GraphContextConfigureOptionsBuilder graphContextConfigureOptionsBuilder)
		{
			var myShopifyUri = BuildShopUri((string) ContextArguments.First(e => e.Key == "MyShopifyName").Value);
			
			var authenticationHeaderName = "X-Shopify-Access-Token";
			var authenticationHeaderValue = (string) ContextArguments.First(e => e.Key == "Authorization").Value;

			Action<GraphSetConfigurationBuilder> graphSetConfigurationBuilder = builder =>
			{
				builder.WithUrl(myShopifyUri);

				builder.ConfigureHttp(httpBuilder =>
				{
					httpBuilder.AddHeader(authenticationHeaderName, authenticationHeaderValue);

					httpBuilder.WithMethod(HttpMethod.Post);
				});
			};
			
			graphContextConfigureOptionsBuilder.ConfigureSet<PublishPublishableMutationResult>(graphSetConfigurationBuilder);
			
			graphContextConfigureOptionsBuilder.ConfigureSet<UnPublishPublishableMutationResult>(graphSetConfigurationBuilder);
		}
	}
}