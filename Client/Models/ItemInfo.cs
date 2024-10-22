using Newtonsoft.Json;

namespace Client.Models
{
    public class ItemInfo
    {
        // variant_id	
        // string
        // Catalog Variant ID of the item ordered. See Catalog API *Required if no other IDs given
        [JsonProperty("variant_id")]
        public string VariantId { get; set; }

        // external_variant_id	
        // string
        // External Variant ID of the item ordered. See Ecommerce Platform Sync API. *Required if no other IDs given
        [JsonProperty("external_variant_id")]
        public string ExternalVariantId { get; set; }

        // warehouse_product_variant_id	
        // string
        // Warehouse product variant ID of the item ordered. See Warehouse Products API. *Required if no other IDs given
        [JsonProperty("warehouse_product_variant_id")]
        public string WarehouseProductVariantId { get; set; }

        // quantity
        // required
        // integer
        // Number of items ordered
        [JsonProperty("quantity")]
        public int Quantity { get; set; }

        // value	
        // string
        // Item retail value - optional but can help to properly calculate
        [JsonProperty("value")]
        public string Value { get; set; }
    }
}