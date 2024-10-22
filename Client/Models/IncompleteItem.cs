using Newtonsoft.Json;

namespace Client.Models
{
    public class IncompleteItem
    {
        // name	
        // string
        // Incomplete item name
        [JsonProperty("name")]
        public string Name { get; set; }

        // quantity	
        // integer
        // Incompleted item quantity
        [JsonProperty("quantity")]
        public int Quantity { get; set; }

        // sync_variant_id	
        // integer
        // Sync variant ID of the incompleted item.
        [JsonProperty("sync_variant_id")]
        public int SyncVariantId { get; set; }

        // external_variant_id	
        // string
        // External variant ID of the incompleted item.
        [JsonProperty("external_variant_id")]
        public string ExternalVariantId { get; set; }

        // external_line_item_id	
        // string
        // External order line item id.
        [JsonProperty("external_line_item_id")]
        public string ExternalLineItemId { get; set; }


    }
}