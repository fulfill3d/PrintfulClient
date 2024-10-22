using Newtonsoft.Json;
using FluentValidation;

namespace Client.Models.Request
{
    public class NewFileRequest
    {
        // type	
        // string
        // Role of the file
        [JsonProperty("type")]
        public string Type { get; set; }

        // url
        // required
        // string
        // Source URL where the file is downloaded from. The use of .ai .psd and .tiff files have been depreciated,
        // if your application uses these file types or accepts these types from users you will need to add validation.
        [JsonProperty("url")]
        public string Url { get; set; }

        // options	
        // Array of objects (FileOption)
        // Array of additional options for this file See examples
        [JsonProperty("options")]
        public List<FileOption> Options { get; set; }

        // filename	
        // string
        // File name
        [JsonProperty("filename")]
        public string Filename { get; set; }

        // visible	
        // boolean
        // Show file in the Printfile Library (default true)
        [JsonProperty("visible")]
        public bool Visible { get; set; }

    }
    
    public class NewFileRequestValidator : AbstractValidator<NewFileRequest>
    {
        public NewFileRequestValidator()
        {
            RuleFor(x => x.Type)
                .NotEmpty()
                .WithMessage("Type must not be empty");

            RuleFor(x => x.Url)
                .NotEmpty()
                .WithMessage("Image url must be provided");

            RuleFor(x => x.Filename)
                .NotEmpty()
                .WithMessage("Filename must be provided");
        }
    }
}