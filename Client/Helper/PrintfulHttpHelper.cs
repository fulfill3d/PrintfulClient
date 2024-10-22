using System.Web;
using Client.Models.Response;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace Client.Helper
{
    public class PrintfulHttpHelper
    {
        // Simplify SendRequestForPrintfulResponse and SendRequestForPrintfulPagedResponse
        public static async Task<PrintfulResponse<TResponse>> SendRequestForPrintfulResponse<TResponse>(
            HttpClient httpClient,
            HttpMethod method, 
            string requestUrl, 
            object content = null) where TResponse : class
        {
            var request = new HttpRequestMessage(method, requestUrl);
            
            request.Content = content == null ? null : new StringContent(JsonConvert.SerializeObject(content));

            var response = await httpClient.SendAsync(request);
            
            if (response.IsSuccessStatusCode)
            {

                var successContent = await response.Content.ReadAsStringAsync();
                var successResponse = PrintfulResponse<TResponse>.FromSuccess(successContent);
                if (successResponse == null) throw new InvalidOperationException("Failed to deserialize the success response.");

                return successResponse;
            }
            
            var errorContent = await response.Content.ReadAsStringAsync();
            var errorResponse = PrintfulResponse<TResponse>.FromError(errorContent);
            if (errorResponse == null) throw new InvalidOperationException("Failed to deserialize the error response.");

            return errorResponse;
        }

        public static async Task<PrintfulPagedResponse<TResponse>> SendRequestForPrintfulPagedResponse<TResponse>(
            HttpClient httpClient,
            HttpMethod method,
            string requestUrl,
            object content = null) where TResponse : class
        {
            var request = new HttpRequestMessage(method, requestUrl);
            
            request.Content = content == null ? null : new StringContent(JsonConvert.SerializeObject(content));

            var response = await httpClient.SendAsync(request);
            
            if (response.IsSuccessStatusCode)
            {

                var successContent = await response.Content.ReadAsStringAsync();
                var successResponse = PrintfulPagedResponse<TResponse>.FromSuccess(successContent);
                if (successResponse == null) throw new InvalidOperationException("Failed to deserialize the success response.");

                return successResponse;
            }
            
            var errorContent = await response.Content.ReadAsStringAsync();
            var errorResponse = PrintfulPagedResponse<TResponse>.FromError(errorContent);
            if (errorResponse == null) throw new InvalidOperationException("Failed to deserialize the error response.");

            return errorResponse;
        }
        
        public static string BuildRequestUrl(
            HttpClient httpClient,
            string route, 
            Dictionary<string, string> queryParams = null)
        {
            var builder = new UriBuilder(httpClient.BaseAddress + route);
            var query = HttpUtility.ParseQueryString(builder.Query);
            
            if (queryParams != null)
            {
                foreach (var param in queryParams)
                {
                    query[param.Key] = param.Value;
                }
            }

            builder.Query = query.ToString();
            return builder.ToString();
        }
    }
}