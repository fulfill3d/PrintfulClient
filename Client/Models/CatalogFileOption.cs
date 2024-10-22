using Newtonsoft.Json;

namespace Client.Models
{
    public class CatalogFileOption
    {
        // id	
        // string
        // File option identifier. Use this to specify which option you are adding to your file in a request.
        [JsonProperty("id")]
        public string Id { get; set; }
        
        // type	
        // string
        // The type of the value property when using this option in a request.
        [JsonProperty("type")]
        public string Type { get; set; }
        
        // title	
        // string
        [JsonProperty("title")]
        public string Title { get; set; }
        
        // additional_price	
        // number
        // Additional cost this will add to the item.
        [JsonProperty("additional_price")]
        public double AdditionalPrice { get; set; }
        
    }
}