using Newtonsoft.Json;

namespace Client.Models.Response
{
    public class Paging
    {
        // total	
        // integer
        // Total number of items available
        [JsonProperty("total")]
        public int Total { get; set; }
        
        // offset	
        // integer
        // Current result set page offset
        [JsonProperty("offset")]
        public int Offset { get; set; }
        
        // limit	
        // integer
        // Max number of items per page
        [JsonProperty("limit")]
        public int Limit { get; set; }

    }
}