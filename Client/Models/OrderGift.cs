using Newtonsoft.Json;

namespace Client.Models
{
    public class OrderGift
    {
        // subject	
        // string <= 200 characters
        // Gift message title
        [JsonProperty("subject")]
        public string Suject { get; set; }
        
        // message	
        // string <= 200 characters
        // Gift message text
        [JsonProperty("message")]
        public string Message { get; set; }

    }
}