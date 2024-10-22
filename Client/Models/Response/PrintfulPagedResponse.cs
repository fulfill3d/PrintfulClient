using Newtonsoft.Json;

namespace Client.Models.Response
{
    // Simplify PrintfulResponse and PrintfulPagedResponse
    public class PrintfulPagedResponse<T>
    {
        [JsonProperty("success")]
        public PagedResponse<T> Success { get; set; }
        
        [JsonProperty("error")]
        public ErrorResponse Error { get; set; }
        
        [JsonProperty("is_success")]
        public bool IsSuccess => Success != null;
        
        public static PrintfulPagedResponse<T> FromSuccess(string response) => new PrintfulPagedResponse<T>
        {
            Success = JsonConvert.DeserializeObject<PagedResponse<T>>(response)
        };
        public static PrintfulPagedResponse<T> FromError(string error) => new PrintfulPagedResponse<T>
        {
            Error = JsonConvert.DeserializeObject<ErrorResponse>(error)
        };
    }
}