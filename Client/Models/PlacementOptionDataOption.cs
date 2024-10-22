using Newtonsoft.Json;

namespace Client.Models
{
    public class PlacementOptionDataOption
    {
        // id	
        // string
        [JsonProperty("id")]
        public string Id { get; set; }
        
        // value	
        // any
        [JsonProperty("value")]
        public object Value { get; set; }

    }
}