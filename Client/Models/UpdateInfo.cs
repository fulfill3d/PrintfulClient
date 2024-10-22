using Newtonsoft.Json;

namespace Client.Models
{
    public class UpdateInfo
    {
        // order	
        // object (Order)
        // Information about the Order
        [JsonProperty("order")]
        public Order Order { get; set; }
    }
}