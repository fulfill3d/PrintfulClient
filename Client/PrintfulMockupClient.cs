using Client.Helper;
using Client.Interfaces;
using Client.Models;
using Client.Models.Query;
using Client.Models.Request;
using Client.Models.Response;
using Client.Options;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace Client
{
    internal class PrintfulMockupClient(
        IOptions<PrintfulAuth> token,
        IHttpClientFactory httpClientFactory,
        ILogger<PrintfulMockupClient> logger): PrintfulBaseClient(httpClientFactory, token), IPrintfulMockupClient
    {
        public async Task<PrintfulResponse<GenerationTask>> CreateMockupGenerationTask(
            long productId,
            MockupRequest requestModel)
        {
            string baseUrl = $"mockup-generator/create-task/{productId}";
            var urlWithParams = PrintfulHttpHelper.BuildRequestUrl(httpClient, baseUrl);
            return await PrintfulHttpHelper.SendRequestForPrintfulResponse<GenerationTask>(
                httpClient, 
                HttpMethod.Post, 
                urlWithParams,
                requestModel);
        }

        public async Task<PrintfulResponse<PrintFileInfo>> RetrieveProductVariantPrintfiles(
            long productId,
            RetrieveProductVariantPrintfile query)
        {
            string baseUrl = $"mockup-generator/printfiles/{productId}";
            var queryParams = new Dictionary<string, string>
            {
                {"orientation", query.Orientation.ToString()},
                {"technique", query.Technique}
            };
            
            var urlWithParams = PrintfulHttpHelper.BuildRequestUrl(httpClient, baseUrl, queryParams);
            
            return await PrintfulHttpHelper.SendRequestForPrintfulResponse<PrintFileInfo>(
                httpClient, 
                HttpMethod.Get, 
                urlWithParams);
        }

        public async Task<PrintfulResponse<GenerationTask>> MockupGenerationTaskResult(CreateMockupGenerationTask query)
        {
            string baseUrl = "mockup-generator/task";
            
            var queryParams = new Dictionary<string, string>
            {
                {"task_key", query.TaskKey}
            };
            
            string urlWithParams = PrintfulHttpHelper.BuildRequestUrl(httpClient, baseUrl, queryParams);
            
            return await PrintfulHttpHelper.SendRequestForPrintfulResponse<GenerationTask>(
                httpClient, 
                HttpMethod.Get, 
                urlWithParams);
        }

        public async Task<PrintfulResponse<MockupProductTemplate>> GetLayoutTemplates(long productId)
        {
            string url = PrintfulHttpHelper.BuildRequestUrl(httpClient, $"mockup-generator/templates/{productId}");
            logger.LogInformation(url);
            return await PrintfulHttpHelper.SendRequestForPrintfulResponse<MockupProductTemplate>(
                httpClient, 
                HttpMethod.Get, 
                url);
        }
    }
}