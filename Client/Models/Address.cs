using Newtonsoft.Json;

namespace Client.Models
{
    public class Address
    {
        // name	
        // string
        // Full name
        [JsonProperty("name")]
        public string Name { get; set; }

        // company	
        // string
        // Company name
        [JsonProperty("company")]
        public string Company { get; set; }

        // address1	
        // string
        // Address line 1
        [JsonProperty("address1")]
        public string Address1 { get; set; }

        // address2	
        // string
        // Address line 2
        [JsonProperty("address2")]
        public string Address2 { get; set; }

        // city	
        // string
        // City
        [JsonProperty("city")]
        public string City { get; set; }

        // state_code	
        // string
        // State code
        [JsonProperty("state_code")]
        public string StateCode { get; set; }

        // state_name	
        // string
        // State name
        [JsonProperty("state_name")]
        public string StateName { get; set; }

        // country_code	
        // string
        // Country code
        [JsonProperty("country_code")]
        public string CountryCode { get; set; }

        // country_name	
        // string
        // Country name
        [JsonProperty("country_name")]
        public string CountryName { get; set; }

        // zip	
        // string
        // ZIP/Postal code
        [JsonProperty("zip")]
        public string Zip { get; set; }

        // phone	
        // string
        // Phone number
        [JsonProperty("phone")]
        public string Phone { get; set; }

        // email	
        // string
        // Email address
        [JsonProperty("email")]
        public string Email { get; set; }

        // tax_number	
        // string
        // TAX number (optional, but in case of Brazil country this field becomes required and will be used as CPF/CNPJ number)
        // CPF format is 000.000.000-00 (14 characters);
        // CNPJ format is 00.000.000/0000-00 (18 characters).
        [JsonProperty("tax_number")]
        public string? TaxNumber { get; set; }


    }
}