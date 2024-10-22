using Newtonsoft.Json;

namespace Client.Models
{
    public class ShippingInfo
    {
        // id	
        // string
        // Shipping method ID
        [JsonProperty("id")]
        public string Id { get; set; }

        // name	
        // string
        // Shipping method name
        [JsonProperty("name")]
        public string Name { get; set; }

        // rate	
        // string
        // Shipping rate
        [JsonProperty("rate")]
        public string Rate { get; set; }

        // currency	
        // string
        // Currency code in which the rate is returned
        [JsonProperty("currency")]
        public string Currency { get; set; }

        // minDeliveryDays	
        // integer
        // Estimated minimum delivery days. Warning! This value may not be present in response.
        [JsonProperty("minDeliveryDays")]
        public int? MinDeliveryDays { get; set; }

        // maxDeliveryDays	
        // integer
        // Estimated maximum delivery days. Warning! This value may not be present in response.
        [JsonProperty("maxDeliveryDays")]
        public int? MaxDeliveryDays { get; set; }

        // minDeliveryDate	
        // integer
        // Estimated minimum delivery date. Warning! This value may not be present in response.
        [JsonProperty("minDeliveryDate")]
        public string? MinDeliveryDate { get; set; }

        // maxDeliveryDate	
        // integer
        // Estimated maximum delivery date. Warning! This value may not be present in response.
        [JsonProperty("maxDeliveryDate")]
        public string? MaxDeliveryDate { get; set; }
    }
}