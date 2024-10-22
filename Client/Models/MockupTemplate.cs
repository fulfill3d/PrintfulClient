using Client.Common;
using Client.Enums;
using Newtonsoft.Json;

namespace Client.Models
{
    public class MockupTemplate
    {
        // template_id	
        // integer
        // Template ID.
        [JsonProperty("template_id")]
        public int TemplateId { get; set; }

        // image_url	
        // string
        // Main template image URL.
        [JsonProperty("image_url")]
        public string ImageUrl { get; set; }

        // background_url	
        // string or null
        // Background image URL (optional).
        [JsonProperty("background_url")]
        public string? BackgroundUrl { get; set; }

        // background_color	
        // integer or null
        // HEX color code that should be used as a background color.
        [JsonProperty("background_color")]
        public int? BackgroundColor { get; set; }

        // printfile_id	
        // integer
        // Printfile ID that should be generated for this template. See printfile API endpoint for list of Printfiles.
        [JsonProperty("printfile_id")]
        public int PrintfileId { get; set; }

        // template_width	
        // integer
        // Width of the whole template in pixels.
        [JsonProperty("template_width")]
        public int TemplateWidth { get; set; }

        // template_height	
        // integer
        // Height of the whole template in pixels.
        [JsonProperty("template_height")]
        public int TemplateHeight { get; set; }

        // print_area_width	
        // integer
        // Print area width (image is positioned in this area).
        [JsonProperty("print_area_width")]
        public int PrintAreaWidth { get; set; }

        // print_area_height	
        // integer
        // Print area height (image is positioned in this area).
        [JsonProperty("print_area_height")]
        public int PrintAreaHeight { get; set; }

        // print_area_top	
        // integer
        // Print area top offset (offset in template).
        [JsonProperty("print_area_top")]
        public int PrintAreaTop { get; set; }

        // print_area_left	
        // integer
        // Print area left offset (offset in template).
        [JsonProperty("print_area_left")]
        public int PrintAreaLeft { get; set; }

        // is_template_on_front	
        // boolean
        // Should the main template image (image_url) be used as an overlay or as a background.
        [JsonProperty("is_template_on_front")]
        public bool IsTemplateOnFront { get; set; }

        // orientation	
        // string
        // Enum: "horizontal" "vertical" "any"
        // Wall art product orientation. Possible values: horizontal, vertical, any
        [JsonProperty("orientation")]
        [JsonConverter(typeof(DescriptionEnumConverter))]
        public PrintOrientation Orientation { get; set; }

    }
}