using Client.Common;
using Client.Enums;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Serialization;

namespace Client.Models
{
    public class Category
    {
        // id	
        // integer
        // Category ID
        [JsonProperty("id")]
        public int Id { get; set; }
        
        // parent_id	
        // integer
        // ID of the parent Category. If there is no parent Category, 0 is returned.
        [JsonProperty("parent_id")]
        public int ParentId { get; set; }
        
        // image_url	
        // string
        // The URL of the Category image
        [JsonProperty("image_url")]
        public string ImageUrl { get; set; }
        
        // size	
        // string
        // Enum: "small" "medium" "large"
        // The size of the category image
        [JsonProperty("size")]
        [JsonConverter(typeof(DescriptionEnumConverter))]
        public CategoryImageSize Size { get; set; }
        
        // title	
        // string
        // Category title
        [JsonProperty("title")]
        public string Title { get; set; }

    }
}