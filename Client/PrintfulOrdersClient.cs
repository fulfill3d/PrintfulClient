using Client.Helper;
using Client.Interfaces;
using Client.Models;
using Client.Models.Query;
using Client.Models.Request;
using Client.Models.Response;
using Client.Options;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace Client
{
    internal class PrintfulOrdersClient(
        IOptions<PrintfulAuth> token,
        IHttpClientFactory httpClientFactory,
        ILogger<PrintfulOrdersClient> logger): PrintfulBaseClient(httpClientFactory, token), IPrintfulOrdersClient
    {
        
        public async Task<PrintfulPagedResponse<Order>> GetOrdersList(OrdersList query)
        {
            var queryParams = new Dictionary<string, string>
            {
                {"status", query.Status},
                {"offset", query.Offset.ToString()},
                {"limit", query.Limit.ToString()}
            };

            var urlWithParams = PrintfulHttpHelper.BuildRequestUrl(httpClient, "/orders", queryParams);
            return await PrintfulHttpHelper.SendRequestForPrintfulPagedResponse<Order>(
                httpClient,
                HttpMethod.Get, 
                urlWithParams);
            
        }

        public async Task<PrintfulResponse<Order>> CreateOrder(NewOrder query, NewOrderRequest requestModel)
        {
            var queryParams = new Dictionary<string, string>
            {
                {"confirm", query.Confirm.ToString()},
                {"update_existing", query.UpdateExisting.ToString()}
            };

            var urlWithParams = PrintfulHttpHelper.BuildRequestUrl(httpClient, "/orders", queryParams);
            return await PrintfulHttpHelper.SendRequestForPrintfulResponse<Order>(
                httpClient, 
                HttpMethod.Post, 
                urlWithParams,
                requestModel);
        }

        public async Task<PrintfulResponse<Order>> GetOrder(int orderId)
        {
            var url = PrintfulHttpHelper.BuildRequestUrl(httpClient, $"/orders/{orderId}");
            return await PrintfulHttpHelper.SendRequestForPrintfulResponse<Order>(
                httpClient, 
                HttpMethod.Get,
                url);
        }

        public async Task<PrintfulResponse<Order>> CancelOrder(int orderId)
        {
            var url = PrintfulHttpHelper.BuildRequestUrl(httpClient, $"/orders/{orderId}");
            return await PrintfulHttpHelper.SendRequestForPrintfulResponse<Order>(
                httpClient,
                HttpMethod.Delete,
                url);
        }

        public async Task<PrintfulResponse<Order>> UpdateOrder(
            int orderId, 
            NewOrder query,
            NewOrderRequest requestModel)
        {
            var queryParams = new Dictionary<string, string>
            {
                {"confirm", query.Confirm.ToString()}
            };

            var urlWithParams = PrintfulHttpHelper.BuildRequestUrl(httpClient, $"/orders/{orderId}", queryParams);
            return await PrintfulHttpHelper.SendRequestForPrintfulResponse<Order>(
                httpClient, 
                HttpMethod.Put, 
                urlWithParams, 
                requestModel);
        }

        public async Task<PrintfulResponse<Order>> ConfirmDraftForFulfillment(int orderId)
        {
            var url = PrintfulHttpHelper.BuildRequestUrl(httpClient, $"/orders/{orderId}/confirm");
            return await PrintfulHttpHelper.SendRequestForPrintfulResponse<Order>(
                httpClient, 
                HttpMethod.Post, 
                url);
        }

        public async Task<PrintfulResponse<OrderEstimate>> EstimateOrderCost(NewOrderRequest requestModel)
        {
            var url = PrintfulHttpHelper.BuildRequestUrl(httpClient, "/orders/estimate-costs");
            return await PrintfulHttpHelper.SendRequestForPrintfulResponse<OrderEstimate>(
                httpClient, 
                HttpMethod.Post, 
                url,
                requestModel);
        }
    }
}