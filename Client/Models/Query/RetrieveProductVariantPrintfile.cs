using Client.Common;
using Client.Enums;
using FluentValidation;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Serialization;

namespace Client.Models.Query
{
    public class RetrieveProductVariantPrintfile
    {
        // orientation	
        // string
        // Enum: "horizontal" "vertical"
        // Optional orientation for wall art product printfiles. Allowed values: horizontal, vertical
        [JsonProperty("orientation")]
        [JsonConverter(typeof(DescriptionEnumConverter))]
        public PrintOrientation? Orientation { get; set; }
        // public string? Orientation { get; set; }

        // technique	
        // string
        // Optional technique for product. This can be used in cases
        // where product supports multiple techniques like DTG and embroidery
        [JsonProperty("technique")]
        public string? Technique { get; set; }

    }

    public class RetrieveProductVariantPrintfileValidator : AbstractValidator<RetrieveProductVariantPrintfile>
    {
        public RetrieveProductVariantPrintfileValidator()
        {
            // RuleFor(p => p.Limit).NotEmpty();
        }
    }
}