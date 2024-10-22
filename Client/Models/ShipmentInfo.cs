using Newtonsoft.Json;

namespace Client.Models
{
    public class ShipmentInfo
    {
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