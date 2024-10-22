using Client.Models;
using Client.Models.Request;
using Client.Models.Response;

namespace Client.Interfaces
{
    public interface IPrintfulPlatformSyncClient
    {
        Task<PrintfulPagedResponse<List<SyncProduct>>> GetSyncProducts(Models.Query.SyncProduct query);
        Task<PrintfulResponse<SyncProductInfo>> GetSyncProduct(int syncProductId);
        Task<PrintfulResponse<SyncProductInfo>> DeleteSyncProduct(int syncProductId);
        Task<PrintfulResponse<SyncProductInfo>> GetSyncVariant(int syncVariantId);
        Task<PrintfulResponse<SyncProductInfo>> ModifySyncVariant(int syncVariantId, SyncVariantRequest requestModel);
        Task<PrintfulResponse<SyncProductInfo>> DeleteSyncVariant(int syncVariantId);
    }
}