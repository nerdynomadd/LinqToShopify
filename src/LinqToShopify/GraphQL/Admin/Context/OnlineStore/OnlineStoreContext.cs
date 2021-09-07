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
using LinqToShopify.GraphQL.Admin.Context.Common.Types.Url;
using LinqToShopify.GraphQL.Admin.Context.OnlineStore.Connection;
using LinqToShopify.GraphQL.Admin.Context.OnlineStore.Types.Script;
using LinqToShopify.GraphQL.Admin.Context.OnlineStore.Types.Script.Input;
using LinqToShopify.GraphQL.Admin.Context.OnlineStore.Types.Script.Mutation.Result;
using LinqToShopify.GraphQL.Admin.Context.OnlineStore.Types.Url;
using LinqToShopify.GraphQL.Admin.Context.OnlineStore.Types.Url.Enum;
using LinqToShopify.GraphQL.Admin.Context.OnlineStore.Types.Url.Input;
using LinqToShopify.GraphQL.Admin.Context.OnlineStore.Types.Url.Mutation.Result;

namespace LinqToShopify.GraphQL.Admin.Context.OnlineStore
{
	/// <summary>
	/// Update a merchant's online storefront and its content.
	/// https://shopify.dev/api/admin/graphql/reference/online-store
	/// </summary>
	public class OnlineStoreContext : ShopifyContext
	{
		public OnlineStoreContext(string myShopifyName, string authorization) : base(new Dictionary<string, object>
		{
			["MyShopifyName"] = myShopifyName,
			["Authorization"] = authorization
		})
		{
		}

		/// <summary>
		/// A list of script tags.
		/// </summary>
		/// <param name="after">Returns the elements that come after the specified cursor.</param>
		/// <param name="before">Returns the elements that come before the specified cursor.</param>
		/// <param name="first">Returns up to the first n elements from the list.</param>
		/// <param name="last">Returns up to the last n elements from the list.</param>
		/// <param name="reverse">Reverse the order of the underlying list.</param>
		/// <param name="url">The source URL of the script tag to filter by.</param>
		/// <returns></returns>
		[GraphName("scriptTags")]
		public GraphSet<ScriptTagConnection> GetScriptTags(string after = null,
			string before = null,
			int? first = null,
			int? last = null,
			bool reverse = false,
			[GraphParameterType(typeof(Url))] string url = null)
		{
			return Set<ScriptTagConnection>(new object[]
			{
				after,
				before,
				first,
				last,
				reverse,
				url
			});
		}
		
		/// <summary>
		/// Lookup a script tag resource by ID.
		/// </summary>
		/// <param name="id">The ID of the ScriptTag to return.</param>
		/// <returns></returns>
		[GraphName("scriptTag")]
		public GraphSet<ScriptTag> GetScriptTag([GraphNonNullableParameter] [GraphParameterType(typeof(ID))] string id)
		{
			return Set<ScriptTag>(new object[]
			{
				id
			});
		}
		
		
		/// <summary>
		/// Returns a redirect resource by ID.
		/// </summary>
		/// <param name="id">The ID of the UrlRedirect to return.</param>
		/// <returns></returns>
		[GraphName("urlRedirect")]
		public GraphSet<UrlRedirect> GetUrlRedirect([GraphNonNullableParameter] [GraphParameterType(typeof(ID))] string id)
		{
			return Set<UrlRedirect>(new object[]
			{
				id
			});
		}
		
		/// <summary>
		/// Sort the underlying list by the given key.
		/// </summary>
		/// <param name="after">Returns the elements that come after the specified cursor.</param>
		/// <param name="before">Returns the elements that come before the specified cursor.</param>
		/// <param name="first">Returns up to the first n elements from the list.</param>
		/// <param name="last">Returns up to the last n elements from the list.</param>
		/// <param name="query"></param>
		/// <param name="reverse">Reverse the order of the underlying list.</param>
		/// <param name="savedSearchId">The ID of an existing saved search. The search’s query string is used as the query argument. Refer to SavedSearch.</param>
		/// <param name="sortKey">Sort the underlying list by the given key.</param>
		/// <returns></returns>
		[GraphName("urlRedirects")]
		public GraphSet<UrlRedirectConnection> GetUrlRedirects(string after = null,
			string before = null,
			int? first = null,
			int? last = null,
			string query = null,
			bool reverse = false,
			[GraphParameterType(typeof(ID))] string savedSearchId = null,
			UrlRedirectSortKeys sortKey = UrlRedirectSortKeys.ID)
		{
			return Set<UrlRedirectConnection>(new object[]
			{
				after,
				before,
				first,
				last,
				query,
				reverse,
				savedSearchId,
				sortKey
			});
		}
		
		/// <summary>
		/// Returns a redirect import resource by ID.
		/// </summary>
		/// <param name="id">The ID of the UrlRedirectImport to return.</param>
		/// <returns></returns>
		[GraphName("urlRedirect")]
		public GraphSet<UrlRedirectImport> GetUrlRedirectImport([GraphNonNullableParameter] [GraphParameterType(typeof(ID))] string id)
		{
			return Set<UrlRedirectImport>(new object[]
			{
				id
			});
		}

		/// <summary>
		/// Creates a new script tag.
		/// https://shopify.dev/api/admin/graphql/reference/online-store/scripttagcreate
		/// </summary>
		/// <param name="input"></param>
		/// <returns></returns>
		[GraphName("scriptTagCreate")]
		public GraphSet<CreateScriptTagUserMutationResult> CreateScriptTag([GraphNonNullableParameter] ScriptTagInput input)
		{
			return Set<CreateScriptTagUserMutationResult>(new object[]
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
		
		/// <summary>
		/// Deletes a script tag.
		/// https://shopify.dev/api/admin/graphql/reference/online-store/scripttagdelete
		/// </summary>
		/// <param name="id">The ID of the script tag to delete.</param>
		/// <returns></returns>
		[GraphName("scriptTagDelete")]
		public GraphSet<DeleteScriptTagUserMutationResult> DeleteScriptTag([GraphNonNullableParameter] [GraphParameterType(typeof(ID))] string id)
		{
			return Set<DeleteScriptTagUserMutationResult>(new object[]
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
		/// Updates a script tag.
		/// https://shopify.dev/api/admin/graphql/reference/online-store/scripttagupdate
		/// </summary>
		/// <param name="id">The ID of the script tag to delete.</param>
		/// <returns></returns>
		[GraphName("scriptTagUpdate")]
		public GraphSet<UpdateScriptTagMutationResult> UpdateScriptTag([GraphNonNullableParameter] [GraphParameterType(typeof(ID))] string id,
			[GraphNonNullableParameter] ScriptTagInput input)
		{
			return Set<UpdateScriptTagMutationResult>(new object[]
			{
				id,
				input
			}, builder =>
			{
				builder.ConfigureQuery(queryBuilder =>
				{
					queryBuilder.WithType(GraphSetTypes.Mutation);
				});
			});
		}

		/// <summary>
		/// Creates a redirect.
		/// </summary>
		/// <param name="urlRedirect">The fields to use when creating the redirect.</param>
		/// <returns></returns>
		[GraphName("urlRedirectCreate")]
		public GraphSet<CreateUrlRedirectMutationResult> CreateUrlRedirect([GraphNonNullableParameter] UrlRedirectInput urlRedirect)
		{
			return Set<CreateUrlRedirectMutationResult>(new object[]
			{
				urlRedirect
			}, builder =>
			{
				builder.ConfigureQuery(queryBuilder =>
				{
					queryBuilder.WithType(GraphSetTypes.Mutation);
				});
			});
		}
		
		/// <summary>
		/// Deletes a redirect.
		/// </summary>
		/// <param name="id">The ID of the redirect to delete.</param>
		/// <returns></returns>
		[GraphName("urlRedirectDelete")]
		public GraphSet<DeleteUrlRedirectMutationResult> DeleteUrlRedirect([GraphNonNullableParameter] [GraphParameterType(typeof(ID))] string id)
		{
			return Set<DeleteUrlRedirectMutationResult>(new object[]
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
		/// Updates a redirect.
		/// </summary>
		/// <param name="id">The ID of the redirect to update.</param>
		/// <param name="urlRedirect">The fields to use when creating the redirect.</param>
		/// <returns></returns>
		[GraphName("urlRedirectUpdate")]
		public GraphSet<CreateUrlRedirectMutationResult> UpdateUrlRedirect([GraphNonNullableParameter] [GraphParameterType(typeof(ID))] string id, [GraphNonNullableParameter] UrlRedirectInput urlRedirect)
		{
			return Set<CreateUrlRedirectMutationResult>(new object[]
			{
				urlRedirect
			}, builder =>
			{
				builder.ConfigureQuery(queryBuilder =>
				{
					queryBuilder.WithType(GraphSetTypes.Mutation);
				});
			});
		}

		/*
		 * TODO: Implement: urlRedirectBulkDeleteBySearch; urlRedirectBulkDeleteBySavedSearch; urlRedirectBulkDeleteByIds; urlRedirectBulkDeleteAll
		 */

		/// <summary>
		/// Creates a URL redirect import.
		/// </summary>
		/// <param name="url">The S3 URL of the CSV file.</param>
		/// <returns></returns>
		[GraphName("urlRedirectImportCreate")]
		public GraphSet<CreateUrlRedirectImportUserMutationResult> CreateUrlRedirectImport([GraphNonNullableParameter] [GraphParameterType(typeof(Url))] string url)
		{
			return Set<CreateUrlRedirectImportUserMutationResult>(new object[]
			{
				url
			}, builder =>
			{
				builder.ConfigureQuery(queryBuilder =>
				{
					queryBuilder.WithType(GraphSetTypes.Mutation);
				});
			});
		}

		/// <summary>
		/// Submits a URL redirect import to be processed.
		/// https://shopify.dev/api/admin/graphql/reference/online-store/urlredirectimportsubmit
		/// </summary>
		/// <param name="id"></param>
		/// <returns></returns>
		[GraphName("urlRedirectImportSubmit")]
		public GraphSet<SubmitUrlRedirectImportMutationResult> SubmitUrlRedirectImport([GraphNonNullableParameter] [GraphParameterType(typeof(ID))] string id)
		{
			return Set<SubmitUrlRedirectImportMutationResult>(new object[]
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
			
			graphContextConfigureOptionsBuilder.ConfigureSet<ScriptTag>(graphSetConfigurationBuilder);
			
			graphContextConfigureOptionsBuilder.ConfigureSet<ScriptTagConnection>(graphSetConfigurationBuilder);
			
			graphContextConfigureOptionsBuilder.ConfigureSet<CreateScriptTagUserMutationResult>(graphSetConfigurationBuilder);
			
			graphContextConfigureOptionsBuilder.ConfigureSet<DeleteScriptTagUserMutationResult>(graphSetConfigurationBuilder);
			
			graphContextConfigureOptionsBuilder.ConfigureSet<UpdateScriptTagMutationResult>(graphSetConfigurationBuilder);
			
			graphContextConfigureOptionsBuilder.ConfigureSet<CreateUrlRedirectMutationResult>(graphSetConfigurationBuilder);
			
			graphContextConfigureOptionsBuilder.ConfigureSet<DeleteUrlRedirectMutationResult>(graphSetConfigurationBuilder);
			
			graphContextConfigureOptionsBuilder.ConfigureSet<UpdateUrlRedirectMutationResult>(graphSetConfigurationBuilder);
			
			graphContextConfigureOptionsBuilder.ConfigureSet<CreateUrlRedirectImportUserMutationResult>(graphSetConfigurationBuilder);
			
			graphContextConfigureOptionsBuilder.ConfigureSet<SubmitUrlRedirectImportMutationResult>(graphSetConfigurationBuilder);
		}
	}
}