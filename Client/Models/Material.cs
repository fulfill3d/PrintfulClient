using Newtonsoft.Json;

namespace Client.Models
{
    public class Material
    {
        // name	
        // string
        // Material name
        [JsonProperty("name")]
        public string Name { get; set; }
        
        // percentage	
        // number
        // Percentage of the material in the product
        [JsonProperty("percentage")]
        public double Percentage { get; set; }
    }
}