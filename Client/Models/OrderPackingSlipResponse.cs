using Newtonsoft.Json;

namespace Client.Models
{
    public class OrderPackingSlipResponse
    {
        // packing_slip	
        // OrderPackingSlip (object)
        [JsonProperty("packing_slip")]
        public OrderPackingSlip PackingSlip { get; set; }

    }
}