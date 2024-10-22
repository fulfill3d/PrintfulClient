using Newtonsoft.Json;

namespace Client.Models.Response
{
    public class CategoryResponse
    {
        // id	
        // integer
        // Category ID
        [JsonProperty("category")]
        public Category Category { get; set; }
    }
    
    public class CategoriesResponse
    {
        // id	
        // integer
        // Category ID
        [JsonProperty("categories")]
        public List<Category> Categories { get; set; }
    }
}