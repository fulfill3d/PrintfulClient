using Newtonsoft.Json;

namespace Client.Models.Query
{
    public class OrdersList
    {
        // status	
        // string
        // Filter by order status
        [JsonProperty("status")]
        public string Status { get; set; }
        
        // offset	
        // integer
        // Result set offset
        [JsonProperty("offset")]
        public int Offset { get; set; }
        
        // limit	
        // integer
        // Number of items per page (max 100)
        [JsonProperty("limit")]
        public int Limit { get; set; }
    }
}