using Newtonsoft.Json;

namespace Client.Models
{
    public class PrintFileInfo
    {
        // product_id	
        // integer
        // Requested product id.
        [JsonProperty("product_id")]
        public int ProductId { get; set; }
        
        // available_placements	
        // object
        // List of available placements. Key is placement identifier, value is display name. (e.g. {embroidery_front: Front, ..}).
        [JsonProperty("available_placements")]
        public Dictionary<string, string> AvailablePlacements { get; set; }

        // printfiles	
        // Array of objects (Printfile)
        [JsonProperty("printfiles")]
        public List<PrintFile> Printfiles { get; set; }

        // variant_printfiles	
        // Array of objects (VariantPrintfile)
        [JsonProperty("variant_printfiles")]
        public List<VariantPrintFile> VariantPrintfiles { get; set; }

        // option_groups	
        // Array of strings
        [JsonProperty("option_groups")]
        public List<string> OptionGroups { get; set; }

        // options	
        // Array of strings
        [JsonProperty("options")]
        public List<string> Options { get; set; }

    }
}