using Newtonsoft.Json;

namespace Client.Models.Request
{
    public class NewOrderRequest
    {
        // external_id	
        // string
        // Order ID from the external system
        [JsonProperty("external_id")]
        public string ExternalId { get; set; }

        // shipping	
        // string
        // Shipping method. Defaults to 'STANDARD'
        [JsonProperty("shipping")]
        public string Shipping { get; set; }

        // recipient
        // required
        // object (Address)
        // Information about the address
        [JsonProperty("recipient")]
        public Address Recipient { get; set; }

        // items
        // required
        // Array of objects (Item)
        // Array of items in the order
        [JsonProperty("items")]
        public List<Item> Items { get; set; }

        // retail_costs	
        // object (OrderRetailCosts)
        // Retail costs that are to be displayed on the packing slip for international shipments. Retail costs are used only if every item in order contains the retail_price attribute.
        [JsonProperty("retail_costs")]
        public OrderRetailCost RetailCosts { get; set; }

        // gift	
        // object (OrderGift)
        // Optional gift message for the packing slip
        [JsonProperty("gift")]
        public OrderGift Gift { get; set; }

        // packing_slip	
        // OrderPackingSlip (object) or OrderPackingSlip (object) or OrderPackingSlip (object) or OrderPackingSlip (object) (OrderPackingSlip)
        // Custom packing slip for this order. Example of a packing slip with explained fields can be found here.
        [JsonProperty("packing_slip")]
        public OrderPackingSlip PackingSlip { get; set; }

    }
}