using Client.Models;
using Client.Models.Response;

namespace Client.Interfaces
{
    public interface IPrintfulStoreInfoClient
    {
        Task<PrintfulResponse<OrderPackingSlipResponse>> ChangePackingSlip(OrderPackingSlip requestModel);
        Task<PrintfulPagedResponse<List<StoreSummary>>> GetAllStoresSummary();
        Task<PrintfulResponse<StoreSummary>> GetStoreSummary(int storeId);
    }
}