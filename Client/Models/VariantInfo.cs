using Newtonsoft.Json;

namespace Client.Models
{
    public class VariantInfo
    {
        // variant	
        // object (Variant)
        [JsonProperty("variant")]
        public ProductVariant ProductVariant { get; set; }
        
        // product	
        // object (Product)
        // Information about the Product that the Variant belongs to
        [JsonProperty("product")]
        public Product Product { get; set; }

    }
}