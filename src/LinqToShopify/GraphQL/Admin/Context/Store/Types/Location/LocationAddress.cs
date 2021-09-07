using System.Collections.Generic;
using LinqToGraphQL.Attributes;

namespace LinqToShopify.GraphQL.Admin.Context.Store.Types.Location
{
	/// <summary>
	/// Represents the address of the location.
	/// </summary>
	public class LocationAddress
	{
		/// <summary>
		/// The first line of the address for the location.
		/// </summary>
		[GraphName("address1")]
		public string Address1 { get; set; }
		
		/// <summary>
		/// The second line of the address for the location.
		/// </summary>
		[GraphName("address2")]
		public string Address2 { get; set; }
		
		/// <summary>
		/// The city of the location.
		/// </summary>
		[GraphName("city")]
		public string City { get; set; }
		
		/// <summary>
		/// The country of the location.
		/// </summary>
		[GraphName("country")]
		public string Country { get; set; }
		
		/// <summary>
		/// The two-letter country code of the location.
		/// </summary>
		[GraphName("countryCode")]
		public string CountryCode { get; set; }
		
		/// <summary>
		/// A formatted version of the location address.
		/// </summary>
		[GraphName("formatted")]
		public List<string> Formatted { get; set; }
		
		/// <summary>
		/// The latitude coordinates of the location.
		/// </summary>
		[GraphName("latitude")]
		public float Latitude { get; set; }
		
		/// <summary>
		/// The longitude coordinates of the location.
		/// </summary>
		[GraphName("longitude")]
		public float Longitude { get; set; }
		
		/// <summary>
		/// The phone number of the location.
		/// </summary>
		[GraphName("phone")]
		public string Phone { get; set; }
		
		/// <summary>
		/// The province of the location.
		/// </summary>
		[GraphName("province")]
		public string Province { get; set; }
		
		/// <summary>
		/// The code for the region of the address, such as the province, state, or district. For example QC for Quebec, Canada.
		/// </summary>
		[GraphName("provinceCode")]
		public string ProvinceCode { get; set; }
		
		/// <summary>
		/// The ZIP code of the location.
		/// </summary>
		[GraphName("zip")]
		public string Zip { get; set; }
	}
}