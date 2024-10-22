using Newtonsoft.Json;

namespace Client.Models
{
    public class ApprovalSheetWebhookFile
    {
        // confirm_hash	
        // string
        [JsonProperty("confirm_hash")]
        public string ConfirmHash { get; set; }
        
        // submitted_design	
        // string
        [JsonProperty("submitted_design")]
        public string SubmittedDesign { get; set; }

        // recommended_design	
        // string
        [JsonProperty("recommended_design")]
        public string RecommendedDesign { get; set; }

        // approval_sheet	
        // string
        [JsonProperty("approval_sheet")]
        public string ApprovalSheet { get; set; }
    }
}