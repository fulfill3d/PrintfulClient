using Newtonsoft.Json;

namespace Client.Models
{
    public class VariantStock
    {
        // out	
        // Array of integers
        // Variant IDs that are out of stock
        [JsonProperty("out")]
        public List<int> Out { get; set; }
        
        // discontinued	
        // Array of integers
        // Variant IDs that are discontinued
        [JsonProperty("discontinued")]
        public List<int> Discontinued { get; set; }
    }
}