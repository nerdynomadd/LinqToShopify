using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using LinqToGraphQL.Attributes;
using LinqToGraphQL.Context.Options.Builder.Configure;
using LinqToGraphQL.Set;
using LinqToGraphQL.Set.Configuration.Builder;
using LinqToShopify.GraphQL.Admin.Context.App.Connections;
using LinqToShopify.GraphQL.Admin.Context.App.Types.AppInstallation;
using LinqToShopify.GraphQL.Admin.Context.App.Types.AppInstallation.Enum;
using LinqToShopify.GraphQL.Admin.Context.App.Types.Publication;
using LinqToShopify.GraphQL.Admin.Context.Common.Types.Id;

namespace LinqToShopify.GraphQL.Admin.Context.App
{
	public class AppContext : ShopifyContext
	{
		public AppContext(string myShopifyName, string authorization) : base(new Dictionary<string, object>
		{
			["MyShopifyName"] = myShopifyName,
			["Authorization"] = authorization
		})
		{
		}

		/// <summary>
		/// Lookup an App by ID or return the currently authenticated App.
		/// </summary>
		/// <param name="id"></param>
		/// <returns></returns>
		[GraphName("app")]
		public GraphSet<Types.App.App> GetApp(int? id = null)
		{
			return Set<Types.App.App>(new object[]
			{
				id
			});
		}
		
		/// <summary>
		/// Fetches app by handle. Returns null if the app doesn't exist.
		/// </summary>
		/// <param name="id"></param>
		/// <returns></returns>
		[GraphName("appByHandle")]
		public GraphSet<Types.App.App> GetAppByHandle([GraphNonNullableParameter] string handle)
		{
			return Set<Types.App.App>(new object[]
			{
				handle
			});
		}
		
		/// <summary>
		/// Fetches app by apiKey. Returns null if the app doesn't exist.
		/// </summary>
		/// <param name="id"></param>
		/// <returns></returns>
		[GraphName("appByKey")]
		public GraphSet<Types.App.App> GetAppByKey([GraphNonNullableParameter] string apiKey)
		{
			return Set<Types.App.App>(new object[]
			{
				apiKey
			});
		}

		/// <summary>
		/// List of app installations of a shop.
		/// </summary>
		/// <param name="after">Returns the elements that come after the specified cursor.</param>
		/// <param name="before">Returns the elements that come before the specified cursor.</param>
		/// <param name="category">The category of app installations to fetch.</param>
		/// <param name="first">Returns up to the first n elements from the list.</param>
		/// <param name="last">Returns up to the last n elements from the list.</param>
		/// <param name="privacy">The privacy level of app installations to fetch.</param>
		/// <param name="reverse">Reverse the order of the underlying list.</param>
		/// <param name="sortKey"></param>
		/// <returns></returns>
		[GraphName("appInstallation")]
		public GraphSet<AppInstallationConnection> GetAppInstallations(string? after = null,
			string? before = null,
			AppInstallationCategory? category = null,
			int? first = null,
			int? last = null,
			AppInstallationPrivacy privacy = AppInstallationPrivacy.PUBLIC,
			bool reverse = false,
			AppInstallationSortKeys sortKey = AppInstallationSortKeys.INSTALLED_AT)
		{
			return Set<AppInstallationConnection>(new object[]
			{
				after,
				before,
				category,
				first,
				last,
				privacy,
				reverse,
				sortKey
			});
		}

		/// <summary>
		/// Lookup an AppInstallation by ID or return the AppInstallation for the currently authenticated App.
		/// </summary>
		/// <param name="id">ID used to lookup AppInstallation.</param>
		/// <returns></returns>
		[GraphName("appInstallation")]
		public GraphSet<AppInstallation> GetAppInstallation(int? id = null)
		{
			return Set<AppInstallation>(new object[]
			{
				id
			});
		}

		/// <summary>
		/// Return the AppInstallation for the currently authenticated App.
		/// </summary>
		/// <returns></returns>
		[GraphName("currentAppInstallation")]
		public GraphSet<AppInstallation> CurrentAppInstallation()
		{
			return Set<AppInstallation>(Array.Empty<object>());
		}

		/// <summary>
		/// Lookup a publication by ID.
		/// </summary>
		/// <param name="id"></param>
		/// <returns></returns>
		[GraphName("publication")]
		public GraphSet<Publication> GetPublication([GraphNonNullableParameter] [GraphParameterType(typeof(ID))] string id)
		{
			return Set<Publication>(new object[]
			{
				id
			});
		}
		
		/// <summary>
		/// List of the active publications.
		/// </summary>
		/// <param name="after">Returns the elements that come after the specified cursor.</param>
		/// <param name="before">Returns the elements that come before the specified cursor.</param>
		/// <param name="first">Returns up to the first n elements from the list.</param>
		/// <param name="last">Returns up to the last n elements from the list.</param>
		/// <param name="reverse">Reverse the order of the underlying list.</param>
		/// <returns></returns>
		[GraphName("publication")]
		public GraphSet<PublicationConnection> GetPublications(string? after = null,
			string? before = null,
			int? first = null,
			int? last = null,
			bool reverse = false)
		{
			return Set<PublicationConnection>(new object[]
			{
				after,
				before,
				first,
				last,
				reverse
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
			
			graphContextConfigureOptionsBuilder.ConfigureSet<Types.App.App>(graphSetConfigurationBuilder);
			
			graphContextConfigureOptionsBuilder.ConfigureSet<AppInstallation>(graphSetConfigurationBuilder);
			
			graphContextConfigureOptionsBuilder.ConfigureSet<AppInstallationConnection>(graphSetConfigurationBuilder);
			
			graphContextConfigureOptionsBuilder.ConfigureSet<Publication>(graphSetConfigurationBuilder);
			
			graphContextConfigureOptionsBuilder.ConfigureSet<PublicationConnection>(graphSetConfigurationBuilder);

		}
	}
}