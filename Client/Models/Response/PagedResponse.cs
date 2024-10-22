namespace Client.Models.Response
{
    public class PagedResponse<T>: BaseResponse<T>
    {
        // paging	
        // object (Paging)
        // Paging information
        // [JsonProperty("paging")]
        public Paging Paging { get; set; }
        
    }
}