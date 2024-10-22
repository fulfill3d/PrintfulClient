using Client.Common;
using Client.Enums;
using FluentValidation;
using Newtonsoft.Json;

namespace Client.Models.Request
{
    public class GetSyncProductsRequest
    {
        private SyncProductStatus _status;

        [JsonProperty("status")]
        public string Status
        {
            get => EnumParser.GetEnumDescription(_status);
            set => _status = EnumParser.ParseEnum<SyncProductStatus>(value);
        }
        
        [JsonProperty("category_ids")]
        public List<string> CategoryIds { get; set; }
        
        public string GetCategoryIds()
        {
            return string.Join("", CategoryIds);
        }
    }
    
    
    public class GetSyncProductsRequestValidator : AbstractValidator<GetSyncProductsRequest>
    {
        public GetSyncProductsRequestValidator()
        {
            RuleFor(x => x.Status)
                .NotEmpty()
                .WithMessage("Status must not be empty");
        }
    }
}