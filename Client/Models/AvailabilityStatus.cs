using Client.Common;
using Newtonsoft.Json;

namespace Client.Models
{
    public class AvailabilityStatus
    {
        // region	
        // string
        // Region code
        [JsonProperty("region")]
        public string Region { get; set; }
        
        // status	
        // string
        // Stock status. Possible values include: 'in_stock' -
        // available for fulfillment, 'stocked_on_demand' -
        // available for fulfillment, 'discontinued' -
        // permanently unavailable, 'out_of_stock' -
        // temporarily unavailable
        [JsonProperty("status")]
        [JsonConverter(typeof(DescriptionEnumConverter))]
        public Enums.AvailabilityStatus Status { get; set; }

    }
}