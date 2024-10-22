using Newtonsoft.Json;

namespace Client.Models
{
    public class GenerationTaskMockup
    {
        // placement	
        // string
        // Placement identifier.
        [JsonProperty("placement")]
        public string Placement { get; set; }

        // variant_ids	
        // Array of integers
        // List of variant ids this mockup is used for. One mockup can be used for multiple variants.
        [JsonProperty("variant_ids")]
        public List<int> VariantIds { get; set; }

        // mockup_url	
        // string
        // Temporary URL of the primary mockup.
        [JsonProperty("mockup_url")]
        public string MockupUrl { get; set; }

        // extra	
        // Array of objects (GenerationTaskExtraMockup)
        // Optional extra mockups.
        [JsonProperty("extra")]
        public List<GenerationTaskExtraMockup> Extra { get; set; }
    }
}