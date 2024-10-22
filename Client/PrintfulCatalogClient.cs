using Client.Helper;
using Client.Interfaces;
using Client.Models;
using Client.Models.Response;
using Client.Options;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace Client
{
    internal class PrintfulCatalogClient(
        IOptions<PrintfulAuth> token,
        IHttpClientFactory httpClientFactory,
        ILogger<PrintfulCatalogClient> logger): PrintfulBaseClient(httpClientFactory, token), IPrintfulCatalogClient
    {

        public async Task<PrintfulResponse<List<Product>>> GetProducts(long? categoryId)
        {
            string route = "products";
            
            if (categoryId != null)
            {
                route += $"?category_id={categoryId}";
            }
            
            var url = PrintfulHttpHelper.BuildRequestUrl(httpClient, route);
            return await PrintfulHttpHelper.SendRequestForPrintfulResponse<List<Product>>(httpClient, HttpMethod.Get, url);
        }

        public async Task<PrintfulResponse<VariantInfo>> GetVariant(int variantId)
        {
            var url = PrintfulHttpHelper.BuildRequestUrl(httpClient, $"products/variant/{variantId}");
            return await PrintfulHttpHelper.SendRequestForPrintfulResponse<VariantInfo>(httpClient, HttpMethod.Get, url);
        }

        public async Task<PrintfulResponse<ProductInfo>> GetProduct(int productId)
        {
            var url = PrintfulHttpHelper.BuildRequestUrl(httpClient, $"products/{productId}");
            return await PrintfulHttpHelper.SendRequestForPrintfulResponse<ProductInfo>(httpClient, HttpMethod.Get, url);
        }

        public async Task<PrintfulResponse<ProductSizeGuide>> GetProductSizeGuide(int productId)
        {
            var url = PrintfulHttpHelper.BuildRequestUrl(httpClient, $"products/{productId}/sizes");
            return await PrintfulHttpHelper.SendRequestForPrintfulResponse<ProductSizeGuide>(httpClient, HttpMethod.Get, url);
        }

        public async Task<PrintfulResponse<CategoriesResponse>> GetCategories()
        {
            var url = PrintfulHttpHelper.BuildRequestUrl(httpClient, "categories");
            return await PrintfulHttpHelper.SendRequestForPrintfulResponse<CategoriesResponse>(httpClient, HttpMethod.Get, url);
        }

        public async Task<PrintfulResponse<CategoryResponse>> GetCategory(int categoryId)
        {
            var url = PrintfulHttpHelper.BuildRequestUrl(httpClient, $"categories/{categoryId}");
            return await PrintfulHttpHelper.SendRequestForPrintfulResponse<CategoryResponse>(httpClient, HttpMethod.Get, url);
        }
    }
}