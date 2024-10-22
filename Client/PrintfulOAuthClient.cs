using Client.Helper;
using Client.Interfaces;
using Client.Models.Response;
using Client.Options;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace Client
{
    internal class PrintfulOAuthClient(
        IOptions<PrintfulAuth> token,
        IHttpClientFactory httpClientFactory,
        ILogger<PrintfulOAuthClient> logger): PrintfulBaseClient(httpClientFactory, token), IPrintfulOAuthClient
    {
        public async Task<PrintfulResponse<OAuthScopeResponse>> GetOAuthScopes()
        {
            var url = PrintfulHttpHelper.BuildRequestUrl(httpClient, "oauth/scopes");
            return await PrintfulHttpHelper.SendRequestForPrintfulResponse<OAuthScopeResponse>(httpClient, HttpMethod.Get, url);
        }
    }
}