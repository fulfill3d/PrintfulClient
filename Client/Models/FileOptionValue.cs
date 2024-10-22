using Newtonsoft.Json;

namespace Client.Models
{
    public class FileOptionValue
    {
        [JsonProperty("validationHash")]
        public string ValidationHash { get; set; }
        
        [JsonProperty("isValid")]
        public bool IsValid { get; set; }
        
        [JsonProperty("validatedImageUrl")]
        public string ValidatedImageUrl { get; set; }
    }
}