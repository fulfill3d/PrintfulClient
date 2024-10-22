using Newtonsoft.Json;

namespace Client.Models.Response
{
    public class Error
    {
        // reason	
        // string
        [JsonProperty("reason")]
        public string Reason { get; set; }
        
        // message	
        // string
        [JsonProperty("message")]
        public string Message { get; set; }

    }
}