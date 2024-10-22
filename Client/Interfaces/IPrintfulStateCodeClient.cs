using Client.Models;
using Client.Models.Response;

namespace Client.Interfaces
{
    public interface IPrintfulStateCodeClient
    {
        Task<PrintfulResponse<List<Country>>> RetrieveStateList();
    }
}