using Client.Common;
using Client.Enums;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Serialization;

namespace Client.Models
{
    public class PrintFile
    {
        // printfile_id	
        // integer
        // Unique printfile identifier.
        [JsonProperty("printfile_id")]
        public int PrintfileId { get; set; }
        
        // width	
        // integer
        // Width in pixels.
        [JsonProperty("width")]
        public int Width { get; set; }

        // height	
        // integer
        // Height in pixels.
        [JsonProperty("height")]
        public int Height { get; set; }

        // dpi	
        // integer
        // Resulting DPI for given width and height.
        [JsonProperty("dpi")]
        public int Dpi { get; set; }

        // fill_mode	
        // string
        // Enum: "cover" "fit"
        // Indicates if printfile will be used in cover or fit mode. Cover mode can produce cropping if side ratio does not match printfile.
        [JsonProperty("fill_mode")]
        [JsonConverter(typeof(DescriptionEnumConverter))]
        public PrintFillMode FillMode { get; set; }

        // can_rotate	
        // boolean
        // Indicates if printfile can be rotated horizontally (e.g. for posters).
        [JsonProperty("order")]
        public Order Order { get; set; }
    }
}