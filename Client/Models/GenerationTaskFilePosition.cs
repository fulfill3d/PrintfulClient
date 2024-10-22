using Newtonsoft.Json;

namespace Client.Models
{
    public class GenerationTaskFilePosition
    {
        // area_width	
        // integer or null
        // Positioning area width on print area in pixels
        [JsonProperty("area_width")]
        public int? AreaWidth { get; set; }

        // area_height	
        // integer or null
        // Positioning area height on print area in pixels
        [JsonProperty("area_height")]
        public int? AreaHeight { get; set; }

        // width	
        // integer
        // Width of the image in given area in pixels
        [JsonProperty("width")]
        public int Width { get; set; }

        // height	
        // integer
        // Height of the image in given area in pixels
        [JsonProperty("height")]
        public int Height { get; set; }

        // top	
        // integer
        // Image top offset in given area in pixels
        [JsonProperty("top")]
        public int Top { get; set; }

        // left	
        // integer
        // Image left offset in given area in pixels
        [JsonProperty("left")]
        public int Left { get; set; }

    }
}