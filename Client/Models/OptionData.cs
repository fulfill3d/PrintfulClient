using Client.Common;
using Newtonsoft.Json;

namespace Client.Models
{
    public class OptionData
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
        [JsonConverter(typeof(StringOrEmptyListJsonConverter))]
        public string Value { get; set; }
    }
}