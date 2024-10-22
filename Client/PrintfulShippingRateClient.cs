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
    internal class PrintfulShippingRateClient(
        IOptions<PrintfulAuth> token,
        IHttpClientFactory httpClientFactory,
        ILogger<PrintfulShippingRateClient> logger): PrintfulBaseClient(httpClientFactory, token), IPrintfulShippingRateClient
    {
        public async Task<PrintfulResponse<List<ShippingInfo>>> CalculateShippingRates(
            CalculateShippingRateRequest requestModel)
        {
            var url = PrintfulHttpHelper.BuildRequestUrl(httpClient, "shipping/rates");
            return await PrintfulHttpHelper.SendRequestForPrintfulResponse<List<ShippingInfo>>(httpClient, HttpMethod.Post, url, requestModel);
        }
    }
}