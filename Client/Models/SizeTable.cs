using Client.Common;
using Client.Enums;
using Newtonsoft.Json;

namespace Client.Models
{
    public class SizeTable
    {
        // type
        // required
        // string
        // Enum: "measure_yourself" "product_measure" "international"
        // Size table type
        [JsonProperty("type")]
        [JsonConverter(typeof(DescriptionEnumConverter))]
        public SizeTableType Type { get; set; }
        
        // unit	
        // string
        // Enum: "inches" "cm"
        // The unit the size table values are in
        [JsonProperty("unit")]
        [JsonConverter(typeof(DescriptionEnumConverter))]
        public SizeUnit Unit { get; set; }
        
        // description	
        // string
        // The size table description (HTML)
        [JsonProperty("description")]
        public string Description { get; set; }
        
        // image_url	
        // string
        // The URL of an image showing the measurements
        [JsonProperty("image_url")]
        public string ImageUrl { get; set; }
        
        // image_description	
        // string
        // The description of the measurement image (HTML)
        [JsonProperty("image_description")]
        public string ImageDescription { get; set; }
        
        // measurements
        // required
        // Array of objects (Measurement)
        // The size table measurements
        [JsonProperty("measurements")]
        public List<Measurement> Measurements { get; set; }

    }
}