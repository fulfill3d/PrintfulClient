using Newtonsoft.Json;

namespace Client.Models
{
    public class OrderEstimate
    {
        // costs	
        // object (OrderEstimateCosts)
        // Order costs (Printful prices)
        [JsonProperty("costs")]
        public OrderEstimateCost Costs { get; set; }

        // retail_costs	
        // object (OrderEstimateRetailCosts)
        // Retail costs that are to be displayed on the packing slip for international shipments.
        // Retail costs are used only if every item in order contains the retail_price attribute.
        [JsonProperty("retail_costs")]
        public OrderEstimateRetailCost RetailCosts { get; set; }

    }
}