using Newtonsoft.Json;

namespace Client.Models
{
    public class ThreadColorResponse
    {
        // code	
        // integer
        // Response status code 200
        [JsonProperty("code")]
        public int Code { get; set; }

        // thread_colors	
        // Array of strings
        [JsonProperty("thread_colors")]
        public List<string> ThreadColors { get; set; }

    }
}