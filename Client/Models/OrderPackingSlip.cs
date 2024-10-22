using Newtonsoft.Json;

namespace Client.Models
{
    public class OrderPackingSlip
    {
        // email	
        // string
        // Customer service email
        [JsonProperty("email")]
        public string Email { get; set; }
        
        // phone	
        // string
        // Customer service phone
        [JsonProperty("phone")]
        public string Phone { get; set; }

        // message	
        // string
        // Custom packing slip message
        [JsonProperty("message")]
        public string Message { get; set; }

        // logo_url	
        // string
        // URL address to a sticker we will put on a package
        [JsonProperty("logo_url")]
        public string LogoUrl { get; set; }

        // store_name	
        // string
        // Store name override for the return address
        [JsonProperty("store_name")]
        public string StoreName { get; set; }

        // custom_order_id
        // required
        // string
        // Your own Order ID that will be printed instead of Printful's Order ID
        [JsonProperty("custom_order_id")]
        public string CustomOrderId { get; set; }

    }
}