using Newtonsoft.Json;

namespace Client.Models
{
    public class OrderStatusChange
    {
        // reason	
        // string
        // Reason why the order status was changed.
        [JsonProperty("reason")]
        public string Reason { get; set; }
        
        // order	
        // object (Order)
        // Information about the Order
        [JsonProperty("order")]
        public Order Order { get; set; }
        
    }
}