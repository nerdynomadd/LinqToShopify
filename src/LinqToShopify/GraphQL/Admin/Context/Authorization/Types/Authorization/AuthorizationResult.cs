using System.Text.Json.Serialization;

namespace LinqToShopify.GraphQL.Admin.Context.Installation.Types.Authorization
{
	public class AuthorizationResult
	{
		[JsonPropertyName("access_token")]
		public string AccessToken { get; set; }
		
		[JsonPropertyName("scope")]
		public string Scope { get; set; }
	}
}