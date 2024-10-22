using Newtonsoft.Json;

namespace Client.Models
{
    public class StoreSummary
    {
        // id	
        // integer
        // Store ID
        [JsonProperty("id")]
        public int Id { get; set; }

        // type	
        // string
        // Store type
        [JsonProperty("type")]
        public string Type { get; set; }

        // name	
        // string
        // Store name
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}