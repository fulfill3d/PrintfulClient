using Client.Helper;
using Client.Interfaces;
using Client.Models;
using Client.Models.Request;
using Client.Models.Response;
using Client.Options;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace Client
{
    internal class PrintfulPlatformSyncClient(
        IOptions<PrintfulAuth> token,
        IHttpClientFactory httpClientFactory,
        ILogger<PrintfulPlatformSyncClient> logger): PrintfulBaseClient(httpClientFactory, token), IPrintfulPlatformSyncClient
    {
        
        public async Task<PrintfulPagedResponse<List<SyncProduct>>> GetSyncProducts(Models.Query.SyncProduct query)
        {
            logger.LogInformation("GetSyncProducts");
            // Query generator
            var queryParams = new Dictionary<string, string>
            {
                {"search", query.Search},
                {"offset", query.Offset.ToString()},
                {"limit", query.Limit.ToString()},
                {"status", query.Status}
            };
            logger.LogInformation(queryParams.ToString());

            var urlWithParams = PrintfulHttpHelper.BuildRequestUrl(httpClient, "sync/products", queryParams);
            logger.LogInformation(urlWithParams);
            return await PrintfulHttpHelper.SendRequestForPrintfulPagedResponse<List<SyncProduct>>(httpClient, HttpMethod.Get, urlWithParams);
        }

        public async Task<PrintfulResponse<SyncProductInfo>> GetSyncProduct(int syncProductId)
        {
            var urlWithParams = PrintfulHttpHelper.BuildRequestUrl(httpClient, $"/sync/products/{syncProductId}");
            logger.LogInformation(urlWithParams);
            return await PrintfulHttpHelper.SendRequestForPrintfulResponse<SyncProductInfo>(httpClient, HttpMethod.Get, urlWithParams);
        }

        public async Task<PrintfulResponse<SyncProductInfo>> DeleteSyncProduct(int syncProductId)
        {
            var urlWithParams = PrintfulHttpHelper.BuildRequestUrl(httpClient, $"/sync/products/{syncProductId}");
            return await PrintfulHttpHelper.SendRequestForPrintfulResponse<SyncProductInfo>(httpClient, HttpMethod.Delete, urlWithParams);
        }

        public async Task<PrintfulResponse<SyncProductInfo>> GetSyncVariant(int syncVariantId)
        {
            var urlWithParams = PrintfulHttpHelper.BuildRequestUrl(httpClient, $"/sync/variants/{syncVariantId}");
            return await PrintfulHttpHelper.SendRequestForPrintfulResponse<SyncProductInfo>(httpClient, HttpMethod.Get, urlWithParams);
        }

        public async Task<PrintfulResponse<SyncProductInfo>> ModifySyncVariant(int syncVariantId, SyncVariantRequest requestModel)
        {
            var urlWithParams = PrintfulHttpHelper.BuildRequestUrl(
                httpClient, 
                $"/sync/variants/{syncVariantId}");
            
            return await PrintfulHttpHelper.SendRequestForPrintfulResponse<SyncProductInfo>(
                httpClient, 
                HttpMethod.Put, 
                urlWithParams, 
                requestModel);
        }

        public async Task<PrintfulResponse<SyncProductInfo>> DeleteSyncVariant(int syncVariantId)
        {
            var urlWithParams = PrintfulHttpHelper.BuildRequestUrl(httpClient, $"/sync/variants/{syncVariantId}");
            return await PrintfulHttpHelper.SendRequestForPrintfulResponse<SyncProductInfo>(httpClient, HttpMethod.Delete, urlWithParams);
        }
        
    }
}