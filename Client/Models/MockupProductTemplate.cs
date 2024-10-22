using Newtonsoft.Json;

namespace Client.Models
{
    public class MockupProductTemplate
    {
        // version	
        // integer
        // Resource version. If this changes, resources (positions, images, etc.) should be re-cached.
        [JsonProperty("version")]
        public int Version { get; set; }

        // min_dpi	
        // integer
        // Recommended minimum DPI for given product.
        [JsonProperty("min_dpi")]
        public int MinDpi { get; set; }

        // variant_mapping	
        // Array of objects (TemplateVariantMapping)
        // List of product variants mapped to templates. From this information you can determine which template should be used for a variant.
        [JsonProperty("variant_mapping")]
        public List<MockupTemplateVariantMapping> VariantMapping { get; set; }

        // templates	
        // Array of objects (Template)
        // List of templates. Use variant_mapping to determine which template corresponds to which product variant.
        [JsonProperty("templates")]
        public List<MockupTemplate> Templates { get; set; }

        // conflicting_placements	
        // Array of objects (TemplatePlacementConflict)
        // List of conflicting placements. Used to determine which placements can be used together.
        [JsonProperty("conflicting_placements")]
        public List<MockupTemplatePlacementConflict> ConflictingPlacements { get; set; }
    }
}