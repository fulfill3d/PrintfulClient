using Newtonsoft.Json;

namespace Client.Models.Response
{
    public class OAuthScopeResponse
    {
        [JsonProperty("scopes")]
        public List<OAuthScope> Scopes { get; set; }
    }
}