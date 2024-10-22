using Newtonsoft.Json;

namespace Client.Models
{
    public class OrderEstimateRetailCost
    {
        // currency	
        // string
        // 3 letter currency code
        [JsonProperty("currency")]
        public string Currency { get; set; }

        // subtotal	
        // number
        // Total cost of all items
        [JsonProperty("subtotal")]
        public double Subtotal { get; set; }

        // discount	
        // number
        // Discount sum
        [JsonProperty("discount")]
        public double Discount { get; set; }

        // shipping	
        // number
        // Shipping costs
        [JsonProperty("shipping")]
        public double Shipping { get; set; }

        // tax	
        // number
        // Sum of taxes (not included in the item price)
        [JsonProperty("tax")]
        public double Tax { get; set; }

        // vat	
        // number
        // Sum of vat (not included in the item price)
        [JsonProperty("vat")]
        public double Vat { get; set; }

        // total	
        // number
        // Grand Total (subtotal-discount+tax+vat+shipping)
        [JsonProperty("total")]
        public double Total { get; set; }

    }
}