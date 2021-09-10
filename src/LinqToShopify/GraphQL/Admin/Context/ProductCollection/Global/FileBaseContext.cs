using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using LinqToGraphQL.Attributes;
using LinqToGraphQL.Context.Options.Builder.Configure;
using LinqToGraphQL.Set;
using LinqToGraphQL.Set.Configuration;
using LinqToGraphQL.Set.Configuration.Builder;
using LinqToShopify.GraphQL.Admin.Context.ProductCollection.Global.Types.File.Input;
using LinqToShopify.GraphQL.Admin.Context.ProductCollection.Global.Types.File.Mutation;
using LinqToShopify.GraphQL.Admin.Context.ProductCollection.Global.Types.Publication.Mutation;

namespace LinqToShopify.GraphQL.Admin.Context.ProductCollection.Global
{
	public class FileBaseContext : ShopifyBaseContext
	{
		public FileBaseContext(string myShopifyName, string authorization) : base(new Dictionary<string, object>
		{
			["MyShopifyName"] = myShopifyName,
			["Authorization"] = authorization
		})
		{
		}

		[GraphName("fileCreate")]
		public GraphSet<CreateFileMutationResult> CreateFile([GraphNonNullableParameter] [GraphParameterTypeName("[FileCreateInput!]")] List<FileCreateInput> files)
		{
			return Set<CreateFileMutationResult>(new object[]
			{
				files
			}, builder =>
			{
				builder.ConfigureQuery(queryBuilder =>
				{
					queryBuilder.WithType(GraphSetTypes.Mutation);
				});
			});
		}
		
		[GraphName("fileDelete")]
		public GraphSet<DeleteFileMutationResult> DeleteFile([GraphNonNullableParameter] [GraphParameterTypeName("[Id!]")] List<string> fileIds)
		{
			return Set<DeleteFileMutationResult>(new object[]
			{
				fileIds
			}, builder =>
			{
				builder.ConfigureQuery(queryBuilder =>
				{
					queryBuilder.WithType(GraphSetTypes.Mutation);
				});
			});
		}
		
		[GraphName("fileUpdate")]
		public GraphSet<UpdateFileMutationResult> UpdateFile([GraphNonNullableParameter] [GraphParameterTypeName("[FileUpdateInput!]")] List<FileUpdateInput> files)
		{
			return Set<UpdateFileMutationResult>(new object[]
			{
				files
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
			
			graphContextConfigureOptionsBuilder.ConfigureSet<CreateFileMutationResult>(graphSetConfigurationBuilder);
			
			graphContextConfigureOptionsBuilder.ConfigureSet<DeleteFileMutationResult>(graphSetConfigurationBuilder);
			
			graphContextConfigureOptionsBuilder.ConfigureSet<UpdateFileMutationResult>(graphSetConfigurationBuilder);
		}
	}
}