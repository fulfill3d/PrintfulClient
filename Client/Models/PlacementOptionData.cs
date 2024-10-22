using Newtonsoft.Json;

namespace Client.Models
{
    public class PlacementOptionData
    {
        // id	
        // string
        [JsonProperty("id")]
        public string Id { get; set; }
        
        // options	
        // Array of objects
        [JsonProperty("options")]
        public List<PlacementOptionDataOption> Options { get; set; }
    }
}