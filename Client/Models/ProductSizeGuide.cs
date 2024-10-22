using Newtonsoft.Json;

namespace Client.Models
{
    public class ProductSizeGuide
    {
        // product_id
        // required
        // integer
        // Product ID
        [JsonProperty("product_id")]
        public string ProductId { get; set; }
        
        // available_sizes
        // required
        // Array of strings
        // The sizes available for the Product
        [JsonProperty("available_sizes")]
        public List<string> AvailableSizes { get; set; }
        
        // size_tables
        // required
        // Array of objects (SizeTable)
        // Size tables for the product
        [JsonProperty("size_tables")]
        public List<SizeTable> SizeTables { get; set; }

    }
}