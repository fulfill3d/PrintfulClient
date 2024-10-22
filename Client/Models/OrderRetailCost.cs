using Newtonsoft.Json;

namespace Client.Models
{
    public class OrderRetailCost
    {
        // currency	
        // string
        // 3 letter currency code
        [JsonProperty("currency")]
        public string Currency { get; set; }

        // subtotal	
        // string or null
        // Total cost of all items
        [JsonProperty("subtotal")]
        public string? Subtotal { get; set; }

        // discount	
        // string or null
        // Discount sum
        [JsonProperty("discount")]
        public string? Discount { get; set; }

        // shipping	
        // string or null
        // Shipping costs
        [JsonProperty("shipping")]
        public string? Shipping { get; set; }

        // tax	
        // string or null
        // Sum of taxes (not included in the item price)
        [JsonProperty("tax")]
        public string? Tax { get; set; }

        // vat	
        // string or null
        // Sum of VAT (not included in the item price)
        [JsonProperty("vat")]
        public string? Vat { get; set; }

        // total	
        // string or null
        // Grand Total (subtotal-discount+tax+vat+shipping)
        [JsonProperty("total")]
        public string? Total { get; set; }


    }
}