using Client.Models;
using Client.Models.Response;

namespace Client
{
    public interface IPrintfulTaxRateClient
    {
        Task<PrintfulResponse<List<Country>>> GetCountryList();
    }
}