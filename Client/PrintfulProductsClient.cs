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
    internal class PrintfulProductsClient(
        IOptions<PrintfulAuth> token,
        IHttpClientFactory httpClientFactory,
        ILogger<PrintfulProductsClient> logger): PrintfulBaseClient(httpClientFactory, token), IPrintfulProductsClient
    {
        public async Task<PrintfulPagedResponse<List<SyncProduct>>> GetSyncProducts(GetSyncProductsRequest requestModel)
        {
            // genereric queryDict Builder
            var queryParams = new Dictionary<string, string>
            {
                {"status", requestModel.Status},
                {"category_id", requestModel.GetCategoryIds()}
            };

            var urlWithParams = PrintfulHttpHelper.BuildRequestUrl(httpClient, "store/products", queryParams);
            return await PrintfulHttpHelper.SendRequestForPrintfulPagedResponse<List<SyncProduct>>(httpClient, HttpMethod.Get, urlWithParams);
        }

        public async Task<PrintfulResponse<SyncProductInfo>> GetSyncProduct(long syncProductId)
        {
            var url = PrintfulHttpHelper.BuildRequestUrl(httpClient, $"store/products/{syncProductId}");
            return await PrintfulHttpHelper.SendRequestForPrintfulResponse<SyncProductInfo>(httpClient, HttpMethod.Get, url);
        }

        public async Task<PrintfulResponse<SyncProduct>> CreateNewSyncProduct(SyncProductRequest requestModel)
        {
            var url = PrintfulHttpHelper.BuildRequestUrl(httpClient, "store/products");
            return await PrintfulHttpHelper.SendRequestForPrintfulResponse<SyncProduct>(httpClient, HttpMethod.Post, url, requestModel);
        }

        public async Task<PrintfulResponse<SyncProductInfo>> DeleteSyncProduct(long syncProductId)
        {
            var url = PrintfulHttpHelper.BuildRequestUrl(httpClient, $"store/products/{syncProductId}");
            return await PrintfulHttpHelper.SendRequestForPrintfulResponse<SyncProductInfo>(httpClient, HttpMethod.Delete, url);
        }

        public async Task<PrintfulResponse<SyncProduct>> ModifySyncProduct(
            long syncProductId, SyncProductRequest requestModel)
        {
            var url = PrintfulHttpHelper.BuildRequestUrl(httpClient, $"store/products/{syncProductId}");
            return await PrintfulHttpHelper.SendRequestForPrintfulResponse<SyncProduct>(httpClient, HttpMethod.Put, url, requestModel);
        }

        public async Task<PrintfulResponse<SyncVariant>> GetSyncVariant(long syncVariantId)
        {
            var url = PrintfulHttpHelper.BuildRequestUrl(httpClient, $"store/variants/{syncVariantId}");
            logger.LogInformation(url);
            return await PrintfulHttpHelper.SendRequestForPrintfulResponse<SyncVariant>(httpClient, HttpMethod.Get, url);
        }

        public async Task<PrintfulResponse<List<long>>> DeleteSyncVariant(long syncVariantId)
        {
            var url = PrintfulHttpHelper.BuildRequestUrl(httpClient, $"store/variants/{syncVariantId}");
            return await PrintfulHttpHelper.SendRequestForPrintfulResponse<List<long>>(httpClient, HttpMethod.Delete, url);
        }

        public async Task<PrintfulResponse<SyncVariant>> ModifySyncVariant(long syncVariantId,
            SyncVariantRequest requestModel)
        {
            var url = PrintfulHttpHelper.BuildRequestUrl(httpClient, $"store/variants/{syncVariantId}");
            return await PrintfulHttpHelper.SendRequestForPrintfulResponse<SyncVariant>(httpClient, HttpMethod.Put, url, requestModel);
        }

        public async Task<PrintfulResponse<SyncVariant>> CreateNewSyncVariant(long syncProductId,
            SyncVariantRequest requestModel)
        {
            var url = PrintfulHttpHelper.BuildRequestUrl(httpClient, $"store/products/{syncProductId}/variants");
            return await PrintfulHttpHelper.SendRequestForPrintfulResponse<SyncVariant>(httpClient, HttpMethod.Post, url, requestModel);
        }
    }
}