using System.Net;
using Client.Common;
using Newtonsoft.Json;

namespace Client.Models.Response
{
    public class BaseResponse<T>
    {
        // code	
        // integer
        // Response status code 200
        [JsonProperty("code")]
        [JsonConverter(typeof(IntegerEnumConverter))]
        public HttpStatusCode Code { get; set; }
        
        // result	
        // object (ProductSizeGuide)
        // Size Guide information for the Product
        [JsonProperty("result")]
        public T Result { get; set; }
        
    }
}