using Newtonsoft.Json;

namespace Client.Models.Response
{
    public class ProductTemplateResponse
    {
        [JsonProperty("items")]
        public List<ProductTemplate> Items { get; set; }
    }
}