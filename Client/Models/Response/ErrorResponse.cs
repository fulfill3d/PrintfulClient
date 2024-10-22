using Newtonsoft.Json;

namespace Client.Models.Response
{
    public class ErrorResponse: BaseResponse<string>
    {
        // error	
        // object
        [JsonProperty("error")]
        public Error Error { get; set; }
    }
}