using Client.Common;
using Newtonsoft.Json;

namespace Client.Models
{
    public class OptionType
    {
        // id	
        // string
        // Option identifier - use this to specify the option when creating an order
        [JsonProperty("id")]
        public string Id { get; set; }
        
        // title	
        // string
        // Display name
        [JsonProperty("title")]
        public string Title { get; set; }
        
        // type	
        // string
        // Data type of this option (currently only 'bool' is supported)
        [JsonProperty("type")]
        public string Type { get; set; }
        
        // values	
        // object
        // Possible option values - [key, value] map
        // property name*
        // additional property
        // any
        [JsonProperty("values")]
        [JsonConverter(typeof(CustomJsonConverter))]
        public Dictionary<string, string>? Values { get; set; }
        
        // additional_price	
        // string
        // Additional price when this option is used
        [JsonProperty("additional_price")]
        public string AdditionalPrice { get; set; }
        
        // additional_price_breakdown	
        // object
        // Additional price breakdown by type - [key, value] map
        // property name*
        // additional property
        // any
        [JsonProperty("additional_price_breakdown")]
        [JsonConverter(typeof(CustomJsonConverter))]
        public Dictionary<string, string>? AdditionalPriceBreakdown { get; set; }
        
    }
}