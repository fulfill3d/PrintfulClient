using FluentValidation;
using Newtonsoft.Json;

namespace Client.Models.Request
{
    public class AvailableThreadColorsRequest
    {
        // file_url	
        // string
        // URL to file
        [JsonProperty("file_url")]
        public string FileUrl { get; set; }

    }
    
    public class AvailableThreadColorsRequestValidator : AbstractValidator<AvailableThreadColorsRequest>
    {
        public AvailableThreadColorsRequestValidator()
        {
            RuleFor(x => x.FileUrl)
                .NotEmpty()
                .WithMessage("File url must not be empty");
        }
    }
    
}