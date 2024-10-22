using Newtonsoft.Json;

namespace Client.Models
{
    public class AvailableTechnique
    {
        // key	
        // string
        // The technique key to be used in the API
        [JsonProperty("key")]
        public string Key { get; set; }
        
        // display_name	
        // string
        // The human-readable technique name
        [JsonProperty("display_name")]
        public string DisplayName { get; set; }
        
        // is_default	
        // boolean
        // Whether the technique is the default one
        [JsonProperty("is_default")]
        public bool IsDefault { get; set; }
        
    }
}
