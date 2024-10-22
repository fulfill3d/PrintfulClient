using Newtonsoft.Json;

namespace Client.Models
{
    public class MeasurementValue
    {
        // size
        // string
        // The size with which the value is associated
        [JsonProperty("size")]
        public string Size { get; set; }
        
        // value	
        // string
        // The single value associated with a size (whether this or min_value and max_value will be present)
        [JsonProperty("value")]
        public string Value { get; set; }
        
        // min_value	
        // string
        // The lower boundary of the value range (whether this and max_value or value will be present)
        [JsonProperty("min_value")]
        public string MinValue { get; set; }
        
        // max_value	
        // string
        // The upper boundary of the value range (whether this and min_value or value will be present)
        [JsonProperty("max_value")]
        public string MaxValue { get; set; }

    }
}