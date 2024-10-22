using Newtonsoft.Json;

namespace Client.Models
{
    public class Item
    {
        // id	
        // integer
        // Line item ID
        [JsonProperty("id")]
        public int Id { get; set; }

        // external_id	
        // string
        // Line item ID from the external system
        [JsonProperty("external_id")]
        public string ExternalId { get; set; }

        // variant_id	
        // integer
        // Variant ID of the item ordered. See Catalog API
        [JsonProperty("variant_id")]
        public int VariantId { get; set; }

        // sync_variant_id	
        // integer
        // Sync variant ID of the item ordered. Example.
        [JsonProperty("sync_variant_id")]
        public int SyncVariantId { get; set; }

        // external_variant_id	
        // string
        // External variant ID of the item ordered. Example.
        [JsonProperty("external_variant_id")]
        public string ExternalVariantId { get; set; }

        // warehouse_product_variant_id	
        // integer
        // Warehousing product variant ID of the item ordered. See Warehouse Products API
        [JsonProperty("warehouse_product_variant_id")]
        public int WarehouseProductVariantId { get; set; }

        // product_template_id	
        // integer
        // The ID of a Product Template to generate the printfiles from. The variant_id field must be passed as well. Can't be combined with following fields: sync_variant_id, external_variant_id, warehouse_product_variant_id, files, options, external_product_id. Examples.
        [JsonProperty("product_template_id")]
        public int ProductTemplateId { get; set; }

        // quantity	
        // integer
        // Number of items ordered (Limited to 1000 for one item)
        [JsonProperty("quantity")]
        public int Quantity { get; set; }

        // price	
        // string
        // Printful price of the item
        [JsonProperty("price")]
        public string Price { get; set; }

        // retail_price	
        // string
        // Original retail price of the item to be displayed on the packing slip
        [JsonProperty("retail_price")]
        public string RetailPrice { get; set; }

        // name	
        // string
        // Display name of the item. If not given, a name from the Printful system will be displayed on the packing slip
        [JsonProperty("name")]
        public string Name { get; set; }

        // product	
        // object (ProductVariant)
        // Short information about the Printful Product and Variant
        [JsonProperty("product")]
        public ProductVariant Product { get; set; }

        // files	
        // Array of objects (File)
        // Array of attached printfiles / preview images
        [JsonProperty("files")]
        public List<File> Files { get; set; }

        // options	
        // Array of objects (ItemOption)
        // Array of additional options for this product See examples
        [JsonProperty("options")]
        public List<ItemOption> Options { get; set; }

        // sku	
        // string
        // Product identifier (SKU) from the external system
        [JsonProperty("sku")]
        public string Sku { get; set; }

        // discontinued	
        // boolean
        // Whether the item belongs to discontinued product i.e. it's permanently unavailable
        [JsonProperty("discontinued")]
        public bool Discontinued { get; set; }

        // out_of_stock	
        // boolean
        // Whether the item is out of stock i.e. temporarily unavailable
        [JsonProperty("out_of_stock")]
        public bool OutOfStock { get; set; }
        
    }
}