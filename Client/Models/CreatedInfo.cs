using Newtonsoft.Json;

namespace Client.Models
{
    public class CreatedInfo
    {
        // order	
        // object (Order)
        // Information about the Order
        [JsonProperty("order")]
        public Order Order { get; set; }
    }
}