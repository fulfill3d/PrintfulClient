using Client.Common;
using Client.Enums;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Serialization;

namespace Client.Models
{
    public class Order
    {
        // id	
        // integer
        // Order ID
        [JsonProperty("id")]
        public int Id { get; set; }

        // external_id	
        // string
        // Order ID from the external system
        [JsonProperty("external_id")]
        public string ExternalId { get; set; }

        // store	
        // integer
        // Store ID
        [JsonProperty("store")]
        public int Store { get; set; }

        // status	
        // string
        // Order status:
        // draft - order is not submitted for fulfillment
        // failed - order was submitted for fulfillment but was not accepted because of an error (problem with address, printfiles, charging, etc.)
        // pending - order has been submitted for fulfillment
        // canceled - order is canceled
        // onhold - order has encountered a problem during the fulfillment that needs to be resolved together with the Printful customer service inprocess - order is being fulfilled and is no longer cancellable
        // partial - order is partially fulfilled (some items are shipped already, the rest will follow)
        // fulfilled - all items are shipped
        [JsonProperty("status")]
        [JsonConverter(typeof(DescriptionEnumConverter))]
        public OrderStatus Status { get; set; }

        // shipping	
        // string
        // Shipping method. Defaults to 'STANDARD'
        [JsonProperty("shipping")]
        public string Shipping { get; set; }

        // shipping_service_name	
        // string
        // Human readable shipping method name.
        [JsonProperty("shipping_service_name")]
        public string ShippingServiceName { get; set; }

        // created	
        // integer
        // Time when the order was created
        [JsonProperty("created")]
        public int Created { get; set; }

        // updated	
        // integer
        // Time when the order was updated
        [JsonProperty("updated")]
        public int Updated { get; set; }

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

        // branding_items	
        // Array of objects (Item)
        // Array of branding items in the order
        [JsonProperty("branding_items")]
        public List<Item> BrandingItems { get; set; }

        // incomplete_items	
        // Array of objects (IncompleteItem)
        // Array of incomplete items in the order
        [JsonProperty("incomplete_items")]
        public List<IncompleteItem> IncompleteItems { get; set; }

        // costs	
        // object (OrderCosts)
        // Order costs (Printful prices)
        [JsonProperty("costs")]
        public OrderCost Costs { get; set; }

        // retail_costs	
        // object (OrderRetailCosts)
        // Retail costs that are to be displayed on the packing slip for international shipments. Retail costs are used only if every item in order contains the retail_price attribute.
        [JsonProperty("retail_costs")]
        public OrderRetailCost RetailCosts { get; set; }

        // pricing_breakdown	
        // Array of objects (PricingBreakdown)
        // Difference between order price and retail costs. Will be shown only if order is completed.
        [JsonProperty("pricing_breakdown")]
        public List<PricingBreakdown> PricingBreakdown { get; set; }

        // shipments	
        // Array of objects (OrderShipment)
        // Array of shipments already shipped for this order
        [JsonProperty("shipments")]
        public List<OrderShipment> Shipments { get; set; }

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