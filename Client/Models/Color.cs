using Newtonsoft.Json;

namespace Client.Models
{
    public class Color
    {
        // color_name	
        // string
        [JsonProperty("color_name")]
        public string ColorName { get; set; }
        
        // color_codes	
        // Array of arrays
        // check if color codes are available
        [JsonProperty("color_codes")]
        public List<string>? ColorCodes { get; set; }

    }
}