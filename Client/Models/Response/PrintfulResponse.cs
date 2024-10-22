using Newtonsoft.Json;

namespace Client.Models.Response
{
    // Simplify PrintfulResponse and PrintfulPagedResponse
    public class PrintfulResponse<T>
    {
        [JsonProperty("success")]
        public BaseResponse<T> Success { get; set; }
        
        [JsonProperty("error")]
        public ErrorResponse Error { get; set; }
        
        [JsonProperty("is_success")]
        public bool IsSuccess => Success != null;
        
        public static PrintfulResponse<T> FromSuccess(string response) => new PrintfulResponse<T>
        {
            Success = JsonConvert.DeserializeObject<BaseResponse<T>>(response)
        };
        
        public static PrintfulResponse<T> FromError(string error) => new PrintfulResponse<T>
        {
            Error = JsonConvert.DeserializeObject<ErrorResponse>(error)
        };
    }
}
