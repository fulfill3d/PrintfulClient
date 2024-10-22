using Client.Common;
using Newtonsoft.Json;

namespace Client.Models.Request
{
    public class SyncVariantRequest
    {
        // id	
        // integer
        // Sync Variant ID. Please specify the IDs of all Sync Variants you wish to keep.
        [JsonProperty("id")]
        public int Id { get; set; }

        // external_id	
        // string
        // Variant ID from the Ecommerce platform
        [JsonProperty("external_id")]
        public string ExternalId { get; set; }

        // variant_id	
        // integer
        // Printful Variant ID that this Sync Variant is synced to
        [JsonProperty("variant_id")]
        public int VariantId { get; set; }

        // retail_price	
        // string
        // Retail price that this item is sold for
        [JsonProperty("retail_price")]
        public string RetailPrice { get; set; }

        // is_ignored	
        // boolean
        // Indicates if this Sync Variant is ignored
        [JsonProperty("is_ignored")]
        public bool IsIgnored { get; set; }

        // sku	
        // string or null
        // SKU of this Sync Variant
        [JsonProperty("sku")]
        public string? Sku { get; set; }

        // files	
        // Array of objects (SyncVariantFile)
        // Array of attached printfiles / preview images
        [JsonProperty("files")]
        public List<SyncVariantFile> Files { get; set; }

        // options	
        // Array of objects (SyncVariantOption)
        // Array of additional options for the configured product/variant See examples
        [JsonProperty("options")]
        public List<SyncVariantOption> Options { get; set; }

        // availability_status	
        // string
        // Enum: "active" "discontinued" "out_of_stock" "temporary_out_of_stock"
        // Indicates the status of the Sync Variant.
        [JsonProperty("availability_status")]
        [JsonConverter(typeof(DescriptionEnumConverter))]
        public Enums.AvailabilityStatus AvailabilityStatus { get; set; }
        
    }
}