using FluentValidation;
using Newtonsoft.Json;

namespace Client.Models.Request
{
    public class ProductTemplateListRequest
    {
        // offset	
        // integer
        // Result set offset
        [JsonProperty("offset")]
        public int Offset { get; set; }
        
        // limit	
        // integer
        // Number of items per page (max 100)
        [JsonProperty("limit")]
        public int Limit { get; set; }
    }

    public class ProductTemplateListRequestValidator : AbstractValidator<ProductTemplateListRequest>
    {
        public ProductTemplateListRequestValidator()
        {
            // RuleFor(p => p.Limit).NotEmpty();
        }
    }
}