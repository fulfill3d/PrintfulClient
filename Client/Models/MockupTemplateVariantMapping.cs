using Newtonsoft.Json;

namespace Client.Models
{
    public class MockupTemplateVariantMapping
    {
        // variant_id	
        // integer
        // Product variant ID.
        [JsonProperty("variant_id")]
        public int VariantId { get; set; }

        // templates	
        // Array of objects (TemplateVariantMappingItem)
        // Array of Template Variant Mapping items
        [JsonProperty("templates")]
        public List<MockupTemplateVariantMappingItem> Templates { get; set; }

    }
}