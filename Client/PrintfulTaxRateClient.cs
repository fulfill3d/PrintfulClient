using Client.Helper;
using Client.Models;
using Client.Models.Response;
using Client.Options;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace Client
{
    internal class PrintfulTaxRateClient(
        IOptions<PrintfulAuth> token,
        IHttpClientFactory httpClientFactory,
        ILogger<PrintfulTaxRateClient> logger): PrintfulBaseClient(httpClientFactory, token), IPrintfulTaxRateClient
    {
        public async Task<PrintfulResponse<List<Country>>> GetCountryList()
        {
            var url = PrintfulHttpHelper.BuildRequestUrl(httpClient, "/tax/countries");
            return await PrintfulHttpHelper.SendRequestForPrintfulResponse<List<Country>>(httpClient, HttpMethod.Get, url);
        }
    }
}