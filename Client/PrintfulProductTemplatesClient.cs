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
    internal class PrintfulProductTemplatesClient(
        IOptions<PrintfulAuth> token,
        IHttpClientFactory httpClientFactory,
        ILogger<PrintfulProductTemplatesClient> logger): PrintfulBaseClient(httpClientFactory, token), IPrintfulProductTemplatesClient
    {
        public async Task<PrintfulPagedResponse<ProductTemplateResponse>> GetProductTemplateList(
            ProductTemplateListRequest requestModel)
        {
            var queryParams = new Dictionary<string, string>
            {
                {"offset", requestModel.Offset.ToString()},
                {"limit", requestModel.Limit.ToString()}
            };

            var urlWithParams = PrintfulHttpHelper.BuildRequestUrl(httpClient, "product-templates", queryParams);
            return await PrintfulHttpHelper.SendRequestForPrintfulPagedResponse<ProductTemplateResponse>(httpClient, HttpMethod.Get, urlWithParams);
            
        }

        public async Task<PrintfulResponse<ProductTemplate>> GetProductTemplate(long productTemplateId)
        {
            var url = PrintfulHttpHelper.BuildRequestUrl(httpClient, $"product-templates/{productTemplateId}");
            return await PrintfulHttpHelper.SendRequestForPrintfulResponse<ProductTemplate>(httpClient, HttpMethod.Get, url);
        }

        public async Task<PrintfulResponse<ProductTemplateDelete>> DeleteProductTemplate(long productTemplateId)
        {
            var url = PrintfulHttpHelper.BuildRequestUrl(httpClient, $"product-templates/{productTemplateId}");
            return await PrintfulHttpHelper.SendRequestForPrintfulResponse<ProductTemplateDelete>(httpClient, HttpMethod.Delete, url);
        }
    }
}