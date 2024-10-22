using Newtonsoft.Json;

namespace Client.Models
{
    public class GenerationTaskExtraMockup
    {
        // title	
        // string
        // Display name of the extra mockup.
        [JsonProperty("title")]
        public string Title { get; set; }

        // url	
        // string
        // Temporary URL of the mockup.
        [JsonProperty("url")]
        public string Url { get; set; }

        // option	
        // string
        // Style option name
        [JsonProperty("option")]
        public string Option { get; set; }

        // option_group	
        // string
        // Style option group name
        [JsonProperty("option_group")]
        public string OptionGroup { get; set; }
    }
}