using Client.Helper;
using Client.Interfaces;
using Client.Models;
using Client.Models.Response;
using Client.Options;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace Client
{
    internal class PrintfulStateCodeClient(
        IOptions<PrintfulAuth> token,
        IHttpClientFactory httpClientFactory,
        ILogger<PrintfulStateCodeClient> logger): PrintfulBaseClient(httpClientFactory, token), IPrintfulStateCodeClient
    {
        public async Task<PrintfulResponse<List<Country>>> RetrieveStateList()
        {
            var url = PrintfulHttpHelper.BuildRequestUrl(httpClient, "countries");
            return await PrintfulHttpHelper.SendRequestForPrintfulResponse<List<Country>>(httpClient, HttpMethod.Get, url);
        }
    }
}