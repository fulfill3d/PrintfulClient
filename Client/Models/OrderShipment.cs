using Newtonsoft.Json;

namespace Client.Models
{
    public class OrderShipment
    {
        // id	
        // integer
        // Shipment ID
        [JsonProperty("id")]
        public int Id { get; set; }

        // carrier	
        // string
        // Carrier name
        [JsonProperty("carrier")]
        public string Carrier { get; set; }

        // service	
        // string
        // Delivery service name
        [JsonProperty("service")]
        public string Service { get; set; }

        // tracking_number	
        // string
        // Shipment tracking number
        [JsonProperty("tracking_number")]
        public string TrackingNumber { get; set; }

        // tracking_url	
        // string
        // Shipment tracking URL
        [JsonProperty("tracking_url")]
        public string TrackingUrl { get; set; }

        // created	
        // integer
        // Shipping time
        [JsonProperty("created")]
        public int Created { get; set; }

        // ship_date	
        // string
        // Ship date
        [JsonProperty("ship_date")]
        public string ShipDate { get; set; }

        // shipped_at	
        // string
        // Ship time in unix timestamp
        [JsonProperty("shipped_at")]
        public string ShippedAt { get; set; }

        // reshipment	
        // boolean
        // Whether this is a reshipment
        [JsonProperty("reshipment")]
        public bool Reshipment { get; set; }

        // items	
        // Array of objects (OrderShipmentItem)
        // Array of items in this shipment
        [JsonProperty("items")]
        public List<OrderShipmentItem> Items { get; set; }


    }
}