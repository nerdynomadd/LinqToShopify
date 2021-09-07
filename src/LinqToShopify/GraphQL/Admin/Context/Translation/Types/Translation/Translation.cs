namespace LinqToShopify.GraphQL.Admin.Context.Translation.Types.Translation
{
	public class Translation
	{
		/// <summary>
		/// Translation key.
		/// </summary>
		public string Key { get; set; }
		
		/// <summary>
		/// Translation locale.
		/// </summary>
		public string Locale { get; set; }
		
		/// <summary>
		/// Marked as outdated.
		/// </summary>
		public bool Outdated { get; set; }
		
		/// <summary>
		/// TranslatableResource 
		/// </summary>
		public string Value { get; set; }
	}
}