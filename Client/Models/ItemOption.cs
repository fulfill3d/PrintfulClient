using Newtonsoft.Json;

namespace Client.Models
{
    public class ItemOption
    {
        // id	
        // string
        // Option ID
        [JsonProperty("id")]
        public string Id { get; set; }

        // value	
        // string
        // Option value
        [JsonProperty("value")]
        public string Value { get; set; }

    }
}