using LinqToGraphQL.Attributes;
using LinqToShopify.GraphQL.Admin.Context.Common.Types.CountryCode;
using LinqToShopify.GraphQL.Admin.Context.Translation.Types.Locale.Enum;

namespace LinqToShopify.GraphQL.Admin.Context.Translation.Types.Locale
{
	/// <summary>
	/// Represents the value captured by a localization extension. Localization extensions are additional fields required by certain countries on international orders. For example, some countries require additional fields for customs information or tax identification numbers.
	/// </summary>
	public class LocalizationExtension
	{
		/// <summary>
		/// Country ISO 3166-1 alpha-2 code.
		/// </summary>
		[GraphName("countryCode")]
		public CountryCode CountryCode { get; set; }
		
		/// <summary>
		/// The localized extension keys that are allowed.
		/// </summary>
		[GraphName("key")]
		public LocalizationExtensionKey Key { get; set; }
		
		/// <summary>
		/// The purpose of this localization extension.
		/// </summary>
		[GraphName("purpose")]
		public LocalizationExtensionPurpose Purpose { get; set; }
		
		/// <summary>
		/// The localized extension title.
		/// </summary>
		[GraphName("title")]
		public string Title { get; set; }
		
		/// <summary>
		/// The value of the field.
		/// </summary>
		[GraphName("value")]
		public string Value { get; set; }
	}
}