using Newtonsoft.Json;

namespace Client.Models
{
    public class FailureInfo
    {
        // reason	
        // string
        // Reason why the order has failed.
        [JsonProperty("reason")]
        public string Reason { get; set; }
        
        // order	
        // object (Order)
        // Information about the Order
        [JsonProperty("order")]
        public Order Order { get; set; }
    }
}