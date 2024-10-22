using Newtonsoft.Json;

namespace Client.Models
{
    public class GenerationTaskFile
    {
        // placement	
        // string
        // Placement identifier (front, back, etc.).
        [JsonProperty("placement")]
        public string Placement { get; set; }

        // image_url	
        // string
        // Public URL where your file is stored.
        [JsonProperty("image_url")]
        public string ImageUrl { get; set; }

        // position	
        // object (GenerationTaskFilePosition)
        // Position
        [JsonProperty("position")]
        public GenerationTaskFilePosition Position { get; set; }

        // options	
        // Array of objects (FileOption)
        // Array of additional options for this file See examples
        [JsonProperty("options")]
        public List<FileOption> Options { get; set; }
    }
}