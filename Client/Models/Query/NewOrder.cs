using Newtonsoft.Json;

namespace Client.Models.Query
{
    public class NewOrder
    {
        
        // confirm	
        // boolean
        // Automatically submit the newly created order for fulfillment (skip the Draft phase)
        [JsonProperty("confirm")]
        public bool Confirm { get; set; }

        // update_existing	
        // boolean
        // Try to update existing order if an order with the specified external_id already exists
        [JsonProperty("update_existing")]
        public bool UpdateExisting { get; set; }

    }
}