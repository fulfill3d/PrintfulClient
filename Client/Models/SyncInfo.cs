using Newtonsoft.Json;

namespace Client.Models
{
    public class SyncInfo<T>
    {
        // sync_product	
        // object (SyncProduct)
        // Information about the SyncProduct
        [JsonProperty("sync_product")]
        public T SyncProduct { get; set; }
    }
}