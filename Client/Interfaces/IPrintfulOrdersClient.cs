using Client.Models;
using Client.Models.Query;
using Client.Models.Request;
using Client.Models.Response;

namespace Client.Interfaces
{
    public interface IPrintfulOrdersClient
    {
        Task<PrintfulPagedResponse<Order>> GetOrdersList(OrdersList query);
        Task<PrintfulResponse<Order>> CreateOrder(NewOrder query, NewOrderRequest requestModel);
        Task<PrintfulResponse<Order>> GetOrder(int orderId);
        Task<PrintfulResponse<Order>> CancelOrder(int orderId);
        Task<PrintfulResponse<Order>> UpdateOrder(int orderId, NewOrder query, NewOrderRequest requestModel);
        Task<PrintfulResponse<Order>> ConfirmDraftForFulfillment(int orderId);
        Task<PrintfulResponse<OrderEstimate>> EstimateOrderCost(NewOrderRequest requestModel);
    }
}