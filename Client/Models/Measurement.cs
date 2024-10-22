using Newtonsoft.Json;

namespace Client.Models
{
    public class Measurement
    {
        // type_label	
        // string
        // Measurement type
        [JsonProperty("type_label")]
        public string TypeLabel { get; set; }
        
        // unit	
        // string
        // The measurement unit if it's not defined on the size table level or is different
        [JsonProperty("unit")]
        public string Unit { get; set; }
        
        // values
        // required
        // Array of objects (MeasurementValue)
        // The measurement values for each size
        [JsonProperty("values")]
        public List<MeasurementValue> Values { get; set; }

    }
}