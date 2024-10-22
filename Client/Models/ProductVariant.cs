using Newtonsoft.Json;

namespace Client.Models
{
    public class ProductVariant
    {
        // id	
        // integer
        // Variant ID, use this to specify the product when creating orders
        [JsonProperty("id")]
        public int Id { get; set; }
        
        // product_id	
        // integer
        // ID of the product that this variant belongs to
        [JsonProperty("product_id")]
        public string ProductId { get; set; }
        
        // name	
        // string
        // Display name
        [JsonProperty("name")]
        public string Name { get; set; }
        
        // size	
        // string
        // Item size
        [JsonProperty("size")]
        public string Size { get; set; }
        
        // color	
        // string
        // Item color
        [JsonProperty("color")]
        public string Color { get; set; }
        
        // color_code	
        // string
        // Hexadecimal RGB color code. May not exactly reflect the real-world color
        [JsonProperty("color_code")]
        public string ColorCode { get; set; }
        
        // color_code2	
        // string
        // Secondary hexadecimal RGB color code. May not exactly reflect the real-world color
        [JsonProperty("color_code2")]
        public string ColorCode2 { get; set; }
        
        // image	
        // string
        // URL of a preview image for this variant
        [JsonProperty("image")]
        public string Image { get; set; }
        
        // price	
        // string
        // Variant's price (can change depending on print files and optional settings)
        [JsonProperty("price")]
        public string Price { get; set; }
        
        // in_stock	
        // boolean
        // Stock availability of this variant
        [JsonProperty("in_stock")]
        public string InStock { get; set; }
        
        // availability_regions	
        // object
        // Map of [region code, region name] of regions where the variant is available for fulfillment
        [JsonProperty("availability_regions")]
        public Dictionary<string, string> AvailabilityRegions { get; set; }
        
        // availability_status	
        // Array of objects (AvailabilityStatus)
        // Detailed stock status per region
        [JsonProperty("availability_status")]
        public List<AvailabilityStatus> AvailabilityStatus { get; set; }
        
        // material	
        // Array of objects (Material)
        // A list of materials this Variant is composed of
        [JsonProperty("material")]
        public List<Material> Material { get; set; }
        
    }
}