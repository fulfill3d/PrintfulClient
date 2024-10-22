using Newtonsoft.Json;

namespace Client.Models
{
    public class ProductInfo
    {
        // product	
        // object (Product)
        // Information about the Product that the Variant belongs to
        [JsonProperty("product")]
        public Product Product { get; set; }
        
        // variants	
        // Array of objects (Variant)
        [JsonProperty("variants")]
        public List<ProductVariant> Variants { get; set; }

    }
}