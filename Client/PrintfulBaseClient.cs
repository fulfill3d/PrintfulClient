using System.Net.Http.Headers;
using Client.Options;
using Microsoft.Extensions.Options;

namespace Client
{
    public abstract class PrintfulBaseClient
    {
        protected readonly HttpClient httpClient;
        protected PrintfulBaseClient(IHttpClientFactory httpClientFactory, IOptions<PrintfulAuth> accessToken)
        {
            httpClient = httpClientFactory.CreateClient("printfulbaseclient");
            httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(
                "Bearer",
                accessToken.Value.PrintfulAuthenticationToken);
            
        }
    }
}