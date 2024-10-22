using Client.Common;
using Newtonsoft.Json;

namespace Client.Models
{
    public class SyncVariant
    {
        // id	
        // integer
        // Sync Variant ID
        [JsonProperty("id")]
        public long Id { get; set; }
        
        // external_id	
        // string
        // Variant ID from the Ecommerce platform
        [JsonProperty("external_id")]
        public string ExternalId { get; set; }
        
        // sync_product_id	
        // integer
        // Sync Product ID that this variant belongs to
        [JsonProperty("sync_product_id")]
        public int SyncProductId { get; set; }
        
        // name	
        // string
        // Sync Variant name
        [JsonProperty("name")]
        public string Name { get; set; }
        
        // synced	
        // boolean
        // Indicates if this Sync Variant is properly linked with Printful product
        [JsonProperty("synced")]
        public bool Synced { get; set; }
        
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
        
        // currency	
        // string
        // Currency in which prices are returned
        [JsonProperty("currency")]
        public string Currency { get; set; }
        
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
        
        // product	
        // object (ProductVariant)
        // Short information about the Printful Product and Variant
        [JsonProperty("product")]
        public ProductVariant Product { get; set; }
        
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
        
        // main_category_id	
        // integer or null
        // Printful Variant catalog category ID
        [JsonProperty("main_category_id")]
        public int? MainCategoryId { get; set; }
        
        // warehouse_product_variant_id	
        // integer or null
        // Warehousing variant ID. If sync variant is connected with a warehousing item, this is its ID
        [JsonProperty("warehouse_product_variant_id")]
        public int? WarehouseProductVariantId { get; set; }
        
        // size	
        // string or null
        // The size of the associated Catalog Variant
        [JsonProperty("size")]
        public string? Size { get; set; }
        
        // color	
        // string or null
        // The color of the associated Catalog Variant
        [JsonProperty("color")]
        public string? Color { get; set; }
        
        // availability_status	
        // string
        // Enum: "active" "discontinued" "out_of_stock" "temporary_out_of_stock"
        // Indicates the status of the Sync Variant.
        [JsonProperty("availability_status")]
        [JsonConverter(typeof(DescriptionEnumConverter))]
        public Enums.AvailabilityStatus AvailabilityStatus { get; set; }

    }
}