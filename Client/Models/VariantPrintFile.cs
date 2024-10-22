using Newtonsoft.Json;

namespace Client.Models
{
    public class VariantPrintFile
    {
        // variant_id	
        // integer
        [JsonProperty("variant_id")]
        public int VariantId { get; set; }
        
        // placements	
        // object
        // A key-value object mapping placement identifiers to printfile IDs.
        [JsonProperty("placements")]
        public Dictionary<string, string> Placements { get; set; }
    }
}