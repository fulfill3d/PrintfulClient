using Client.Common;
using Client.Enums;
using FluentValidation;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Serialization;

namespace Client.Models.Request
{
    public class MockupRequest
    {
        
        // variant_ids	
        // Array of integers
        // List of variant ids you want to generate.
        [JsonProperty("variant_ids")]
        public List<int> VariantIds { get; set; }

        // format	
        // string
        // Enum: "jpg" "png"
        // Generated file format. PNG will have a transparent background, JPG will have a smaller file size.
        [JsonProperty("format")]
        [JsonConverter(typeof(DescriptionEnumConverter))]
        public FileFormat Format { get; set; }

        // width	
        // integer
        // Width of the resulting mockup images (min 50, max 2000, default is 1000)
        [JsonProperty("width")]
        public int Width { get; set; }

        // product_options	
        // object
        // Key-value list of product options (embroidery thread, stitch colors). Product options can be found in Catalog API endpoint. See examples
        [JsonProperty("product_options")]
        public Dictionary<string, string> ProductOptions { get; set; }

        // option_groups	
        // Array of strings
        // List of option group names you want to generate. Product's option groups can be found in printfile API request.
        [JsonProperty("option_groups")]
        public List<string> OptionGroups { get; set; }

        // options	
        // Array of strings
        // List of option names you want to generate. Product's options can be found in printfile API request.
        [JsonProperty("options")]
        public List<string> Options { get; set; }

        // files	
        // Array of objects (GenerationTaskFile)
        [JsonProperty("files")]
        public List<GenerationTaskFile> Files { get; set; }

        // product_template_id	
        // integer
        // Product template ID. Use instead of files parameter.
        [JsonProperty("product_template_id")]
        public int ProductTemplateId { get; set; }

    }

    public class MockupRequestValidator : AbstractValidator<MockupRequest>
    {
        public MockupRequestValidator()
        {
            // RuleFor(p => p.Limit).NotEmpty();
        }
    }
}