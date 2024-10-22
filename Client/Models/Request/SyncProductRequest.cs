using FluentValidation;
using Newtonsoft.Json;

namespace Client.Models.Request
{
    public class SyncProductRequest
    {
        
        // sync_product
        // required
        // object (SyncProduct)
        // Information about the SyncProduct
        [JsonProperty("sync_product")]
        public SyncProduct SyncProduct { get; set; }
        
        // sync_variants
        // required
        // Array of objects (SyncVariant)
        // Information about the Sync Variants
        [JsonProperty("sync_variants")]
        public List<SyncVariant> SyncVariants { get; set; }
    }
    
    public class SyncProductRequestValidator : AbstractValidator<SyncProductRequest>
    {
        public SyncProductRequestValidator()
        {
            // RuleFor(x => x.SyncProduct)
            //     .NotEmpty()
            //     .WithMessage("File url must not be empty");
        }
    }
}