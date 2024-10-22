using Newtonsoft.Json;

namespace Client.Models
{
    public class SyncProductInfo
    {
        // sync_product	
        // object (SyncProduct)
        // Information about the SyncProduct
        [JsonProperty("sync_product")]
        public SyncProduct SyncProduct { get; set; }
        
        // sync_variants	
        // Array of objects (SyncVariant)
        // Array of Sync Variants available for the selected product
        [JsonProperty("sync_variants")]
        public List<SyncVariant> SyncVariants { get; set; }

    }
}