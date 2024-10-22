using Newtonsoft.Json;

namespace Client.Models
{
    public class Placement
    {
        // placement	
        // string
        [JsonProperty("placement")]
        public string PlacementValue { get; set; }
        
        // display_name	
        // string
        [JsonProperty("display_name")]
        public string DisplayName { get; set; }
        
        // technique_key	
        // string
        [JsonProperty("technique_key")]
        public string TechniqueKey { get; set; }
        
        // technique_display_name	
        // string
        [JsonProperty("technique_display_name")]
        public string TechniqueDisplayName { get; set; }

    }
}