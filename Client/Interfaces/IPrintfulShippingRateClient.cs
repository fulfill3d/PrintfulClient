using Client.Models;
using Client.Models.Request;
using Client.Models.Response;

namespace Client.Interfaces
{
    public interface IPrintfulShippingRateClient
    {
        Task<PrintfulResponse<List<ShippingInfo>>> CalculateShippingRates(CalculateShippingRateRequest requestModel);
    }
}