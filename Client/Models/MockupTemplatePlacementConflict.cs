using Newtonsoft.Json;

namespace Client.Models
{
    public class MockupTemplatePlacementConflict
    {
        // placement	
        // string
        // Placement ID
        [JsonProperty("placement")]
        public string Placement { get; set; }
        
        // conflicts	
        // Array of strings
        // List Placement IDs that are conflicting with given placement
        [JsonProperty("conflicts")]
        public List<string> Conflicts { get; set; }
    }
}