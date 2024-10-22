using Newtonsoft.Json;

namespace Client.Models
{
    public class FileType
    {
        public FileType()
        {
            Options = new List<CatalogFileOption>();
        }
        
        // type	
        // string
        // File type identifier - use this to specify a file's purpose when creating an order See examples
        [JsonProperty("type")]
        public string Type { get; set; }
        
        // title	
        // string
        // Display name
        [JsonProperty("title")]
        public string Title { get; set; }
        
        // additional_price	
        // string
        // Additional price when this print file type is used
        [JsonProperty("additional_price")]
        public string AdditionalPrice { get; set; }
        
        // options	
        // Array of objects (CatalogFileOption)
        // Additional options available to product files
        [JsonProperty("options")]
        public List<CatalogFileOption> Options { get; set; }
        
    }
}