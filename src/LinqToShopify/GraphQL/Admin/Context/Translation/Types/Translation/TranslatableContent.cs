namespace LinqToShopify.GraphQL.Admin.Context.Translation.Types.Translation
{
	/// <summary>
	/// Translatable content of a resource's field.
	/// </summary>
	public class TranslatableContent
	{
		/// <summary>
		/// Digest (hash) of the content.
		/// </summary>
		public bool Digest { get; set; }
		
		/// <summary>
		/// Content key.
		/// </summary>
		public string Key { get; set; }
		
		/// <summary>
		/// Content locale.
		/// </summary>
		public string Locale { get; set; }
		
		/// <summary>
		/// Content value.
		/// </summary>
		public string Value { get; set; }
	}
}