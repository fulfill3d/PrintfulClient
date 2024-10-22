using Client.Models;
using Client.Models.Request;
using Client.Models.Response;

namespace Client.Interfaces
{
    public interface IPrintfulProductsClient
    {
        Task<PrintfulPagedResponse<List<SyncProduct>>> GetSyncProducts(GetSyncProductsRequest requestModel);
        Task<PrintfulResponse<SyncProductInfo>> GetSyncProduct(long syncProductId);
        Task<PrintfulResponse<SyncProduct>> CreateNewSyncProduct(SyncProductRequest requestModel);
        Task<PrintfulResponse<SyncProductInfo>> DeleteSyncProduct(long syncProductId);
        Task<PrintfulResponse<SyncProduct>> ModifySyncProduct(long syncProductId, SyncProductRequest requestModel);
        Task<PrintfulResponse<SyncVariant>> GetSyncVariant(long syncVariantId);
        Task<PrintfulResponse<List<long>>> DeleteSyncVariant(long syncVariantId);
        Task<PrintfulResponse<SyncVariant>> ModifySyncVariant(long syncVariantId, SyncVariantRequest requestModel);
        Task<PrintfulResponse<SyncVariant>> CreateNewSyncVariant(long syncProductId, SyncVariantRequest requestModel);

    }
}