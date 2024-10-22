using Newtonsoft.Json;

namespace Client.Models
{
    public class ProductStock
    {
        // product_id	
        // integer
        // Product ID
        [JsonProperty("product_id")]
        public int ProductId { get; set; }

        // variant_stock	
        // object (VariantStock)
        // Variant stock for this product
        [JsonProperty("variant_stock")]
        public VariantStock VariantStock { get; set; }
    }
}