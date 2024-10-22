using Newtonsoft.Json;

namespace Client.Models
{
    public class MockupTemplateVariantMappingItem
    {
        // placement	
        // string
        // Placement ID.
        [JsonProperty("placement")]
        public string Placement { get; set; }

        // template_id	
        // integer
        // Corresponding template id which should be used for this variant and placement combination.
        [JsonProperty("template_id")]
        public int TemplateId { get; set; }
    }
}