using Newtonsoft.Json;

namespace Client.Models
{
    public class GenerationTaskTemplateFile
    {
        // variant_ids	
        // Array of integers
        // List of variant IDs associated with printfiles.
        [JsonProperty("variant_ids")]
        public List<int> VariantIds { get; set; }

        // placement	
        // string
        // Placement identifier (front, back, etc.).
        [JsonProperty("placement")]
        public string Placement { get; set; }

        // url	
        // string
        // Public URL where your file is stored.
        [JsonProperty("url")]
        public string Url { get; set; }
    }
}