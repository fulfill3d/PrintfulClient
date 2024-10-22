using Newtonsoft.Json;

namespace Client.Models
{
    public class Country
    {
        // code	
        // string
        // Country code
        [JsonProperty("code")]
        public string Code { get; set; }

        // name	
        // string
        // Country name
        [JsonProperty("name")]
        public string Name { get; set; }

        // states	
        // Array of objects or null (State)
        [JsonProperty("states")]
        public List<State>? States { get; set; }

        // region	
        // string
        [JsonProperty("region")]
        public string Region { get; set; }

    }
}