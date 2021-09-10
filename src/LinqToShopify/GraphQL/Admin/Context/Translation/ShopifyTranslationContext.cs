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
using LinqToShopify.GraphQL.Admin.Context.Translation.Connection;
using LinqToShopify.GraphQL.Admin.Context.Translation.Types.Locale;
using LinqToShopify.GraphQL.Admin.Context.Translation.Types.Locale.Mutation.Input;
using LinqToShopify.GraphQL.Admin.Context.Translation.Types.Locale.Mutation.Result;
using LinqToShopify.GraphQL.Admin.Context.Translation.Types.Translation;
using LinqToShopify.GraphQL.Admin.Context.Translation.Types.Translation.Enum;
using LinqToShopify.GraphQL.Admin.Context.Translation.Types.Translation.Mutation.Input;
using LinqToShopify.GraphQL.Admin.Context.Translation.Types.Translation.Mutation.Result;

namespace LinqToShopify.GraphQL.Admin.Context.Translation
{
	public class ShopifyTranslationContext : ShopifyBaseContext
	{
		internal ShopifyTranslationContext(string myShopifyName, string authorization) : base(new Dictionary<string, object>
		{
			["MyShopifyName"] = myShopifyName,
			["Authorization"] = authorization
		})
		{
		}

		/// <summary>
		/// List of available locales.
		/// </summary>
		/// <returns></returns>
		[GraphName("availableLocales")]
		public GraphSet<Locale> GetAvailableLocales()
		{
			return Set<Locale>();
		}

		/// <summary>
		/// List of locales available on a shop.
		/// https://shopify.dev/api/admin/graphql/reference/common-objects/queryroot#shopLocales-2021-07
		/// </summary>
		/// <param name="published">Return only published locales.</param>
		/// <returns></returns>
		[GraphName("shopLocales")]
		public GraphSet<ShopLocale> GetShopLocales(bool? published = null)
		{
			return Set<ShopLocale>(new object[]
			{
				published
			});
		}

		/// <summary>
		/// Translatable resource.
		/// https://shopify.dev/api/admin/graphql/reference/common-objects/queryroot#translatableResource-2021-07
		/// </summary>
		/// <param name="resourceId"></param>
		/// <returns></returns>
		[GraphName("translatableResource")]
		public GraphSet<TranslatableResource> GetTranslatableResource([GraphNonNullableParameter] [GraphParameterType(typeof(ID))] string resourceId)
		{
			return Set<TranslatableResource>(new object[]
			{
				resourceId
			});
		}
		
		/// <summary>
		/// List of translatable resources.
		/// https://shopify.dev/api/admin/graphql/reference/common-objects/queryroot#translatableresources-2021-07
		/// </summary>
		/// <param name="translatableResourceType">Return only resources of a type.</param>
		/// <param name="after">Returns the elements that come after the specified cursor.</param>
		/// <param name="before">Returns the elements that come before the specified cursor.</param>
		/// <param name="first">Returns up to the first n elements from the list.</param>
		/// <param name="last">Returns up to the last n elements from the list.</param>
		/// <param name="reverse">Reverse the order of the underlying list.</param>
		/// <returns></returns>
		[GraphName("translatableResources")]
		public GraphSet<TranslatableResourceConnection> GetTranslatableResources([GraphNonNullableParameter] TranslatableResourceType translatableResourceType, 
			string after = null,
			string before = null,
			int? first = null,
			int? last = null,
			bool reverse = false)
		{
			return Set<TranslatableResourceConnection>(new object[]
			{
				translatableResourceType, after, before, first, last, reverse
			});
		}

		/// <summary>
		/// Creates or updates translations.
		/// </summary>
		/// <param name="resourceId">ID of a translatable resource.</param>
		/// <param name="translations">Specifies the input fields for a translation.</param>
		/// <returns></returns>
		[GraphName("translationsRegister")]
		public GraphSet<RegisterTranslationsUserMutationResult> RegisterTranslations([GraphNonNullableParameter] [GraphParameterType(typeof(ID))] string resourceId,
			[GraphNonNullableParameter] List<TranslationInput> translations)
		{
			return Set<RegisterTranslationsUserMutationResult>(new object[]
			{
				resourceId, translations
			}, builder =>
			{
				builder.ConfigureQuery(queryBuilder =>
				{
					queryBuilder.WithType(GraphSetTypes.Mutation);
				});
			});
		}
		
		/// <summary>
		/// Removes translations.
		/// </summary>
		/// <param name="locales">List of translation locales.</param>
		/// <param name="resourceId">ID of a translatable resource.</param>
		/// <param name="translationKeys">List of translation keys.</param>
		/// <returns></returns>
		[GraphName("translationsRemove")]
		public GraphSet<RemoveTranslationsUserMutationResult> RemoveTranslations([GraphNonNullableParameter] [GraphParameterTypeName("[String!]")] List<string> locales,
			[GraphNonNullableParameter] [GraphParameterType(typeof(ID))] string resourceId,
			[GraphNonNullableParameter] [GraphParameterTypeName("[String!]")] string translationKeys)
		{
			return Set<RemoveTranslationsUserMutationResult>(new object[]
			{
				locales,
				resourceId,
				translationKeys
			}, builder =>
			{
				builder.ConfigureQuery(queryBuilder =>
				{
					queryBuilder.WithType(GraphSetTypes.Mutation);
				});
			});
		}

		/// <summary>
		/// Disables a locale for a shop.
		/// https://shopify.dev/api/admin/graphql/reference/translations/shoplocaledisable
		/// </summary>
		/// <param name="locale">Specifies the locale to disable.</param>
		/// <returns></returns>
		[GraphName("shopLocaleDisable")]
		public GraphSet<DisableShopLocaleUserMutationResult> DisableShopLocale([GraphNonNullableParameter] string locale)
		{
			return Set<DisableShopLocaleUserMutationResult>(new object[]
			{
				locale
			}, builder =>
			{
				builder.ConfigureQuery(queryBuilder =>
				{
					queryBuilder.WithType(GraphSetTypes.Mutation);
				});
			});
		}
		
		/// <summary>
		/// Enables a locale for a shop.
		/// https://shopify.dev/api/admin/graphql/reference/translations/shoplocaleenable
		/// </summary>
		/// <param name="locale">Specifies the locale to enable.</param>
		/// <returns></returns>
		[GraphName("shopLocaleEnable")]
		public GraphSet<EnableShopLocaleMutationResult> EnableShopLocale([GraphNonNullableParameter] string locale)
		{
			return Set<EnableShopLocaleMutationResult>(new object[]
			{
				locale
			}, builder =>
			{
				builder.ConfigureQuery(queryBuilder =>
				{
					queryBuilder.WithType(GraphSetTypes.Mutation);
				});
			});
		}
		
		/// <summary>
		/// Specifies the locale to enable.
		/// https://shopify.dev/api/admin/graphql/reference/translations/shoplocaleupdate
		/// </summary>
		/// <param name="locale">Specifies the locale to update.</param>
		/// <param name="shopLocale">Specifies the input fields for a shop locale.</param>
		/// <returns></returns>
		[GraphName("shopLocaleUpdate")]
		public GraphSet<UpdateShopLocaleUserMutationResult> UpdateShopLocale([GraphNonNullableParameter] string locale, [GraphNonNullableParameter] ShopLocaleInput shopLocale)
		{
			return Set<UpdateShopLocaleUserMutationResult>(new object[]
			{
				locale,
				shopLocale
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
			
			graphContextConfigureOptionsBuilder.ConfigureSet<Locale>(graphSetConfigurationBuilder);
			
			graphContextConfigureOptionsBuilder.ConfigureSet<ShopLocale>(graphSetConfigurationBuilder);
			
			graphContextConfigureOptionsBuilder.ConfigureSet<TranslatableResource>(graphSetConfigurationBuilder);
			
			graphContextConfigureOptionsBuilder.ConfigureSet<TranslatableResourceConnection>(graphSetConfigurationBuilder);
			
			graphContextConfigureOptionsBuilder.ConfigureSet<RegisterTranslationsUserMutationResult>(graphSetConfigurationBuilder);
			
			graphContextConfigureOptionsBuilder.ConfigureSet<RemoveTranslationsUserMutationResult>(graphSetConfigurationBuilder);
			
			graphContextConfigureOptionsBuilder.ConfigureSet<DisableShopLocaleUserMutationResult>(graphSetConfigurationBuilder);
			
			graphContextConfigureOptionsBuilder.ConfigureSet<EnableShopLocaleMutationResult>(graphSetConfigurationBuilder);
			
			graphContextConfigureOptionsBuilder.ConfigureSet<UpdateShopLocaleUserMutationResult>(graphSetConfigurationBuilder);
		}
	}
}