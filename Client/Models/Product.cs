using Newtonsoft.Json;

namespace Client.Models
{
    public class Product
    {
        public Product()
        {
            Files = new List<FileType>();
            Options = new List<OptionType>();
            Techniques = new List<AvailableTechnique>();
        }
        
        // id	
        // integer
        // Product ID
        [JsonProperty("id")]
        public int Id { get; set; }
        
        // main_category_id	
        // integer
        // Main category of product
        [JsonProperty("main_category_id")]
        public int MainCategoryId { get; set; }
        
        // type	
        // string
        // Product type identifier
        [JsonProperty("type")]
        public string Type { get; set; }
        
        // type_name	
        // string
        // Product type name
        [JsonProperty("type_name")]
        public string TypeName { get; set; }
        
        // title	
        // string
        // Product title
        [JsonProperty("title")]
        public string Title { get; set; }
        
        // brand	
        // string
        // Brand name
        [JsonProperty("brand")]
        public string Brand { get; set; }
        
        // model	
        // string
        // Model name
        [JsonProperty("model")]
        public string Model { get; set; }
        
        // image	
        // string
        // URL of a sample image for this product
        [JsonProperty("image")]
        public string Image { get; set; }
        
        // variant_count	
        // integer
        // Number of available variants for this product
        [JsonProperty("variant_count")]
        public int VariantCount { get; set; }
        
        // currency	
        // string
        // Currency in which prices are returned
        [JsonProperty("currency")]
        public string Currency { get; set; }
        
        // files	
        // Array of objects (FileType)
        // Definitions of Print/Mockup file categories that can be attached to this product
        [JsonProperty("files")]
        public List<FileType> Files { get; set; }
        
        // options	
        // Array of objects (OptionType)
        // Definitions of additional options that are available for this product See examples
        [JsonProperty("options")]
        public List<OptionType> Options { get; set; }
        
        // is_discontinued	
        // boolean
        // If product is disabled in push
        [JsonProperty("is_discontinued")]
        public bool IsDiscontinued { get; set; }
        
        // avg_fulfillment_time	
        // number
        // Average number of days for order to be fulfilled
        [JsonProperty("avg_fulfillment_time")]
        public double? AvgFulfillmentTime { get; set; }
        
        // description	
        // string
        // Product description
        [JsonProperty("description")]
        public string Description { get; set; }
        
        // techniques	
        // Array of objects (AvailableTechnique)
        // Available techniques
        [JsonProperty("techniques")]
        public List<AvailableTechnique> Techniques { get; set; }
        
        // origin_country	
        // string or null
        // The origin country for inside label
        [JsonProperty("origin_country")]
        public string? OriginCountry { get; set; }

    }
}