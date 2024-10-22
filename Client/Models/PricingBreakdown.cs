using Newtonsoft.Json;

namespace Client.Models
{
    public class PricingBreakdown
    {
        // customer_pays	
        // string
        // Amount customer paid
        [JsonProperty("customer_pays")]
        public string CustomerPays { get; set; }

        // printful_price	
        // string
        // Printful price
        [JsonProperty("printful_price")]
        public string PrintfulPrice { get; set; }

        // profit	
        // string
        // Profit
        [JsonProperty("profit")]
        public string Profit { get; set; }

        // currency_symbol	
        // string
        // Shipment tracking number
        [JsonProperty("currency_symbol")]
        public string CurrencySymbol { get; set; }


    }
}