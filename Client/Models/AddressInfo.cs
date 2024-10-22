using Newtonsoft.Json;

namespace Client.Models
{
    public class AddressInfo
    {
        // address1
        // required
        // string
        // Address line 1
        [JsonProperty("address1")]
        public string Address1 { get; set; }

        // city
        // required
        // string
        // City
        [JsonProperty("city")]
        public string City { get; set; }

        // country_code
        // required
        // string
        // Country code
        [JsonProperty("country_code")]
        public string CountryCode { get; set; }

        // state_code	
        // string
        // State code (optional, required for United States, Australia and Canada)
        [JsonProperty("state_code")]
        public string StateCode { get; set; }

        // zip	
        // string
        // ZIP or postal code (optional, required for some countries to calculate expedited shipping rates)
        [JsonProperty("zip")]
        public string Zip { get; set; }

        // phone	
        // string
        // Phone number (optional)
        [JsonProperty("phone")]
        public string Phone { get; set; }
    }
}