using Newtonsoft.Json;

namespace Client.Models
{
    public class ProductTemplate
    {
        // id	
        // integer
        [JsonProperty("id")]
        public int Id { get; set; }
        
        // product_id	
        // integer
        [JsonProperty("product_id")]
        public int ProductId { get; set; }
        
        // external_product_id	
        // string
        [JsonProperty("external_product_id")]
        public string ExternalProductId { get; set; }
        
        // title	
        // string
        [JsonProperty("title")]
        public string Title { get; set; }
        
        // available_variant_ids	
        // Array of integers
        [JsonProperty("available_variant_ids")]
        public List<int> AvailableVariantIds { get; set; }
        
        // option_data	
        // Array of objects
        [JsonProperty("option_data")]
        public List<OptionData> OptionData { get; set; }
        
        // colors	
        // Array of objects
        [JsonProperty("colors")]
        public List<Color> Colors { get; set; }
        
        // sizes	
        // Array of strings
        [JsonProperty("sizes")]
        public List<string> Sizes { get; set; }
        
        // mockup_file_url	
        // string
        [JsonProperty("mockup_file_url")]
        public string MockupFileUrl { get; set; }
        
        // placements	
        // Array of objects
        [JsonProperty("placements")]
        public List<Placement> Placements { get; set; }
        
        // created_at	
        // integer
        [JsonProperty("created_at")]
        public int CreatedAt { get; set; }
        
        // updated_at	
        // integer
        [JsonProperty("updated_at")]
        public int UpdatedAt { get; set; }
        
        // placement_option_data	
        // Array of objects
        [JsonProperty("placement_option_data")]
        public List<PlacementOptionData> PlacementOptionData { get; set; }

    }
}