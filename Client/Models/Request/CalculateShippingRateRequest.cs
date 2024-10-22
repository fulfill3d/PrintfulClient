using FluentValidation;
using Newtonsoft.Json;

namespace Client.Models.Request
{
    public class CalculateShippingRateRequest
    {
        // recipient
        // required
        // object (AddressInfo)
        // Recipient location information
        [JsonProperty("recipient")]
        public AddressInfo Recipient { get; set; }

        // items
        // required
        // Array of objects (ItemInfo)
        // Array of order items
        [JsonProperty("items")]
        public List<ItemInfo> Items { get; set; }

        // currency	
        // string
        // 3 letter currency code (optional), required if the rates need to be converted to another currency instead of store default currency
        [JsonProperty("currency")]
        public string Currency { get; set; }

        // locale	
        // string
        // Locale in which shipping rate names will be returned. Available options: en_US (default), es_ES
        [JsonProperty("locale")]
        public string Locale { get; set; }
    }
    
    public class CalculateShippingRateRequestValidator : AbstractValidator<CalculateShippingRateRequest>
    {
        public CalculateShippingRateRequestValidator()
        {
            // Add Rules
            RuleFor(x => x.Recipient.Address1)
                .NotEmpty()
                .WithMessage("Address must not be empty");
        }
    }
}