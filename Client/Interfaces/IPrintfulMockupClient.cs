using Client.Models;
using Client.Models.Query;
using Client.Models.Request;
using Client.Models.Response;

namespace Client.Interfaces
{
    public interface IPrintfulMockupClient
    {
        Task<PrintfulResponse<GenerationTask>> CreateMockupGenerationTask(long productId, MockupRequest requestModel);
        Task<PrintfulResponse<PrintFileInfo>> RetrieveProductVariantPrintfiles(long productId, RetrieveProductVariantPrintfile query);
        Task<PrintfulResponse<GenerationTask>> MockupGenerationTaskResult(CreateMockupGenerationTask query);
        Task<PrintfulResponse<MockupProductTemplate>> GetLayoutTemplates(long productId);
    }
}