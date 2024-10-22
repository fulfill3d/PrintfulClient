using Newtonsoft.Json;

namespace Client.Models
{
    public class OrderCost
    {
        // currency	
        // string
        // 3 letter currency code
        [JsonProperty("currency")]
        public string Currency { get; set; }

        // subtotal	
        // string
        // Total cost of all items
        [JsonProperty("subtotal")]
        public string Subtotal { get; set; }

        // discount	
        // string
        // Discount sum
        [JsonProperty("discount")]
        public string Discount { get; set; }

        // shipping	
        // string
        // Shipping costs
        [JsonProperty("shipping")]
        public string Shipping { get; set; }

        // digitization	
        // string
        // Digitization costs
        [JsonProperty("digitization")]
        public string Digitization { get; set; }

        // additional_fee	
        // string
        // Additional fee for custom product
        [JsonProperty("additional_fee")]
        public string AdditionalFee { get; set; }

        // fulfillment_fee	
        // string
        // Custom product fulfillment fee
        [JsonProperty("fulfillment_fee")]
        public string FulfillmentFee { get; set; }

        // retail_delivery_fee	
        // string
        // Retail delivery fee
        [JsonProperty("retail_delivery_fee")]
        public string RetailDeliveryFee { get; set; }

        // tax	
        // string
        // Sum of taxes (not included in the item price)
        [JsonProperty("tax")]
        public string Tax { get; set; }

        // vat	
        // string
        // Sum of vat (not included in the item price)
        [JsonProperty("vat")]
        public string Vat { get; set; }

        // total	
        // string
        // Grand Total (subtotal-discount+tax+vat+shipping)
        [JsonProperty("total")]
        public string Total { get; set; }

    }
}