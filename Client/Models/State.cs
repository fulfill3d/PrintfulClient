using Newtonsoft.Json;

namespace Client.Models
{
    public class State
    {
        // code	
        // string
        // State code
        [JsonProperty("code")]
        public string Code { get; set; }

        // name	
        // string
        // State name
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}