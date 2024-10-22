using Newtonsoft.Json;

namespace Client.Models
{
    public class SyncProduct
    {
        // id	
        // integer
        // SyncProduct ID
        [JsonProperty("id")]
        public int Id { get; set; }
        
        // external_id	
        // string
        // Product ID from the Ecommerce platform
        [JsonProperty("external_id")]
        public string ExternalId { get; set; }
        
        // name
        // required
        // string
        // Product name
        [JsonProperty("name")]
        public string Name { get; set; }
        
        // variants	
        // integer
        // Total number of Sync Variants belonging to this product
        [JsonProperty("variants")]
        public int Variants { get; set; }
        
        // synced	
        // integer
        // Number of synced Sync Variants belonging to this product
        [JsonProperty("synced")]
        public int Synced { get; set; }
        
        // thumbnail_url	
        // string
        // Thumbnail image for the product
        [JsonProperty("thumbnail_url")]
        public string ThumbnailUrl { get; set; }
        
        // is_ignored	
        // boolean
        // Indicates if this Sync Product is ignored
        [JsonProperty("is_ignored")]
        public bool IsIgnored { get; set; }

    }
}