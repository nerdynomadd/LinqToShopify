namespace LinqToShopify.GraphQL.Admin.Context.ShippingFulfillment.Types
{
	/// <summary>
	/// The attribute editable information.
	/// </summary>
	public class EditableProperty
	{
		/// <summary>
		/// Whether the attribute is locked for editing.
		/// </summary>
		public bool Locked { get; set; }
		
		/// <summary>
		/// The reason the attribute is locked for editing.
		/// </summary>
		public string Reason { get; set; }
	}
}