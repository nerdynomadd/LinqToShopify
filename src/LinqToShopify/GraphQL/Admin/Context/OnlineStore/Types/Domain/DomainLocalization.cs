using System.Collections.Generic;
using LinqToGraphQL.Attributes;

namespace LinqToShopify.GraphQL.Admin.Context.OnlineStore.Types.Domain
{
	/// <summary>
	/// The country and language settings assigned to a domain.
	/// </summary>
	public class DomainLocalization
	{
		/// <summary>
		/// The ISO codes for the domain’s alternate locales.
		/// </summary>
		[GraphName("alternateLocales")]
		public List<string> AlternateLocales { get; set; }
		
		/// <summary>
		/// The ISO code for the country assigned to the domain, or "*" for a domain set to "Rest of world".
		/// </summary>
		[GraphName("country")]
		public string Country { get; set; }
		
		/// <summary>
		/// The ISO code for the domain’s default locale.
		/// </summary>
		[GraphName("defaultLocale")]
		public string DefaultLocale { get; set; }
	}
}