using Newtonsoft.Json;

namespace Client.Models
{
    public class OAuthScope
    {
        // scope	
        // string
        [JsonProperty("scope")]
        public string Scope { get; set; }
        
        // display_name	
        // string
        [JsonProperty("display_name")]
        public string DisplayName { get; set; }
    }
}