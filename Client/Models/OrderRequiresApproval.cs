using Newtonsoft.Json;

namespace Client.Models
{
    public class OrderRequiresApproval
    {
        // reason	
        // string
        // Reason why the order was put on hold and requires approval.
        [JsonProperty("reason")]
        public string Reason { get; set; }
        
        // approval_files	
        // Array of objects (ApprovalSheetWebhookFile)
        [JsonProperty("approval_files")]
        public ApprovalSheetWebhookFile ApprovalFiles { get; set; }
        
        // order	
        // object (Order)
        // Information about the Order
        [JsonProperty("order")]
        public Order Order { get; set; }
    }
}