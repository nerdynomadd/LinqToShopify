using System.Collections.Generic;
using LinqToGraphQL.Attributes;
using LinqToShopify.GraphQL.Admin.Context.Common.Types.CountryCode;
using LinqToShopify.GraphQL.Admin.Context.Translation.Connection;
using LinqToShopify.GraphQL.Admin.Context.Translation.Types.Locale.Enum;

namespace LinqToShopify.GraphQL.Admin.Context.Translation.Types.Interface
{
	/// <summary>
	/// Localization extensions associated with the specified resource. For example, the tax id for government invoice.
	/// </summary>
	public interface IHasLocalizationExtensions
	{
		/// <summary>
		/// List of localization extensions for the resource.
		/// </summary>
		/// <param name="after">Returns the elements that come after the specified cursor.</param>
		/// <param name="before">Returns the elements that come before the specified cursor.</param>
		/// <param name="countryCodes">The country codes of the extensions.</param>
		/// <param name="first">Returns up to the first n elements from the list.</param>
		/// <param name="last">Returns up to the last n elements from the list.</param>
		/// <param name="purposes">The purpose of the extensions.</param>
		/// <param name="reverse">Reverse the order of the underlying list.</param>
		/// <returns></returns>
		public LocalizationExtensionConnection LocalizationExtensions(string after = null,
			string before = null,
			[GraphParameterTypeName("[CountryCode!]")] List<CountryCode>? countryCodes = null,
			int? first = null,
			int? last = null,
			[GraphParameterTypeName("[LocalizationExtensionPurpose!]")] List<LocalizationExtensionPurpose>? purposes = null,
			bool reverse = false
		);
	}
}