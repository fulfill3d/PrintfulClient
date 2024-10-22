using Newtonsoft.Json;

namespace Client.Models
{
    public class ReturnInfo
    {
        // reason	
        // string
        // Reason why the shipment was returned.
        [JsonProperty("reason")]
        public string Reason { get; set; }
        
        // shipment	
        // object (OrderShipment)
        // Information about order shipment
        [JsonProperty("shipment")]
        public OrderShipment Shipment { get; set; }
        
        // order	
        // object (Order)
        // Information about the Order
        [JsonProperty("order")]
        public Order Order { get; set; }

    }
}