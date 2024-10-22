using Newtonsoft.Json;

namespace Client.Models
{
    public class SyncProductDeleted
    {
        // id
        // required
        // integer
        // SyncProduct ID
        [JsonProperty("id")]
        public int Id { get; set; }
        
        // external_id
        // required
        // string
        // Product ID from the Ecommerce platform
        [JsonProperty("external_id")]
        public string ExternalId { get; set; }

        // name
        // required
        // string
        // Product name
        [JsonProperty("name")]
        public string Name { get; set; }

    }
}