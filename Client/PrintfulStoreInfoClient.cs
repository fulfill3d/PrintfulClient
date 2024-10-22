using Client.Helper;
using Client.Interfaces;
using Client.Models;
using Client.Models.Response;
using Client.Options;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace Client
{
    internal class PrintfulStoreInfoClient(
        IOptions<PrintfulAuth> token,
        IHttpClientFactory httpClientFactory,
        ILogger<PrintfulStoreInfoClient> logger): PrintfulBaseClient(httpClientFactory, token), IPrintfulStoreInfoClient
    {
        public async Task<PrintfulResponse<OrderPackingSlipResponse>> ChangePackingSlip(OrderPackingSlip requestModel)
        {
            var url = PrintfulHttpHelper.BuildRequestUrl(httpClient, "/store/packing-slip");
            return await PrintfulHttpHelper.SendRequestForPrintfulResponse<OrderPackingSlipResponse>(
                httpClient, 
                HttpMethod.Post, 
                url);
        }

        public async Task<PrintfulPagedResponse<List<StoreSummary>>> GetAllStoresSummary()
        {
            var url = PrintfulHttpHelper.BuildRequestUrl(httpClient, "/stores");
            return await PrintfulHttpHelper.SendRequestForPrintfulPagedResponse<List<StoreSummary>>(
                httpClient, 
                HttpMethod.Get, 
                url);
        }

        public async Task<PrintfulResponse<StoreSummary>> GetStoreSummary(int storeId)
        {
            var url = PrintfulHttpHelper.BuildRequestUrl(httpClient, $"/stores/{storeId}");
            return await PrintfulHttpHelper.SendRequestForPrintfulResponse<StoreSummary>(
                httpClient, 
                HttpMethod.Get, 
                url);
        }
    }
}