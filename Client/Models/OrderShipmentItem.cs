using Client.Common;
using Client.Enums;
using Newtonsoft.Json;

namespace Client.Models
{
    public class OrderShipmentItem
    {
        // item_id	
        // integer
        // Line item ID
        [JsonProperty("item_id")]
        public int ItemId { get; set; }

        // quantity	
        // integer
        // Quantity of items in this shipment
        [JsonProperty("quantity")]
        public int Quantity { get; set; }

        // picked	
        // integer
        // Enum: 0 1
        // A boolean indicating that the pickup stage of this item's fulfillment has been completed
        [JsonProperty("picked")]
        [JsonConverter(typeof(IntegerEnumConverter))]
        public ItemPicked Picked { get; set; }

        // printed	
        // integer
        // Enum: 0 1
        // A boolean indicting that the item has been printed, sublimated or sewed.
        [JsonProperty("printed")]
        public ItemPrinted Printed { get; set; }


    }
}