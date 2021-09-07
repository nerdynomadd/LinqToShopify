using System.Collections.Generic;
using LinqToShopify.GraphQL.Admin.Context.Translation.Types.Locale.Enum;

namespace LinqToShopify.GraphQL.Admin.Context.Translation.Types.Locale.Mutation.Input
{
	/// <summary>
	/// Specifies the input fields for a LocalizationExtensionInput.
	/// </summary>
	public class LocalizationExtensionInput
	{
		
		/// <summary>
		/// The key for the localization extension.
		/// </summary>
		public List<LocalizationExtensionKey> Keys { get; set; }

		/// <summary>
		/// The localization extension value.
		/// </summary>
		public string Value { get; set; }
	}
}