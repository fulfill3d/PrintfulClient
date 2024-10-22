using Newtonsoft.Json;

namespace Client.Models
{
    public class ProductTemplateDelete
    {
        // success	
        // boolean
        // Whether the deletion was successful
        [JsonProperty("success")]
        public bool Success { get; set; }
    }
}