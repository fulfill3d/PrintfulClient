using Newtonsoft.Json;

namespace Client.Models.Response
{
    public class Item<T>
    {
        // items
        // Array of objects
        [JsonProperty("items")]
        public List<T> Items { get; set; }
        
    }
}