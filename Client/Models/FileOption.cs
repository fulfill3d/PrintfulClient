using Newtonsoft.Json;

namespace Client.Models
{
    public class FileOption
    {
        // id
        // required
        // string
        // Option id
        [JsonProperty("id")]
        public string Id { get; set; }
        
        // value
        // required
        // string
        // Option value
        [JsonProperty("value")]
        public FileOptionValue Value { get; set; }
    }
}