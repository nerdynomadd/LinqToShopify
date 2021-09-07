namespace LinqToShopify.GraphQL.Admin.Context.Global.LegacyInteroperability
{
	/// <summary>
	/// Interoperability metadata for types that directly correspond to a REST Admin API resource. For example, on the Product type, LegacyInteroperability returns metadata for the corresponding Product object in the REST Admin API.
	/// </summary>
	public class LegacyInteroperability : ILegacyInteroperability
	{
		/// <summary>
		/// The ID of the corresponding resource in the REST Admin API.
		/// </summary>
		public ulong LegacyResourceId { get; set; }
	}
}