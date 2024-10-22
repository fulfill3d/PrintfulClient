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
    using File = Models.File;

    public class PrintfulFileLibraryClient(
        IOptions<PrintfulAuth> token,
        IHttpClientFactory httpClientFactory,
        ILogger<PrintfulFileLibraryClient> logger): PrintfulBaseClient(httpClientFactory, token), IPrintfulFileLibraryClient
    {
        public async Task<PrintfulResponse<File>> AddNewFile(NewFileRequest requestModel)
        {
            var url = PrintfulHttpHelper.BuildRequestUrl(httpClient, "files");
            logger.LogInformation(url);
            return await PrintfulHttpHelper.SendRequestForPrintfulResponse<File>(httpClient, HttpMethod.Post, url, requestModel);
        }

        public async Task<PrintfulResponse<File>> GetFile(int fileId)
        {
            var url = PrintfulHttpHelper.BuildRequestUrl(httpClient, $"/files/{fileId}");
            return await PrintfulHttpHelper.SendRequestForPrintfulResponse<File>(httpClient, HttpMethod.Post, url);
        }

        public async Task<PrintfulResponse<ThreadColorResponse>> AvailableThreadColors(AvailableThreadColorsRequest requestModel)
        {
            var url = PrintfulHttpHelper.BuildRequestUrl(httpClient, $"/files/thread-colors");
            return await PrintfulHttpHelper.SendRequestForPrintfulResponse<ThreadColorResponse>(
                httpClient, 
                HttpMethod.Post, 
                url, 
                requestModel);
        }
    }
}