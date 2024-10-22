using Client.Models;
using Client.Models.Request;
using Client.Models.Response;

namespace Client.Interfaces
{
    public interface IPrintfulProductTemplatesClient
    {
        Task<PrintfulPagedResponse<ProductTemplateResponse>> GetProductTemplateList(ProductTemplateListRequest requestModel);
        Task<PrintfulResponse<ProductTemplate>> GetProductTemplate(long productTemplateId);
        Task<PrintfulResponse<ProductTemplateDelete>> DeleteProductTemplate(long productTemplateId);
    }
}