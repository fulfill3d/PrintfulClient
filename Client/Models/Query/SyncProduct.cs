using FluentValidation;
using Newtonsoft.Json;
using Client.Common;
using Client.Enums;

namespace Client.Models.Query
{
    public class SyncProduct
    {
        // search	
        // string
        // Product search needle
        [JsonProperty("search")]
        public string Search { get; set; }

        // offset	
        // integer
        // Result set offset
        [JsonProperty("offset")]
        public int Offset { get; set; }

        // limit	
        // integer
        // Number of items per page (max 100)
        [JsonProperty("limit")]
        public int Limit { get; set; }

        // status	
        // string
        // Enum: "all" "synced" "unsynced" "ignored" "imported" "discontinued" "out_of_stock"
        // Parameter used to filter results by status/group of Sync Products
        [JsonProperty("status")]
        // [JsonConverter(typeof(SyncProductStatusConverter))]
        // public SyncProductStatus Status { get; set; }
        public string Status { get; set; }
        
        // public string GetStatus()
        // {
        //     switch (Status)
        //     {
        //         case SyncProductStatus.All:
        //             return "all";
        //         case SyncProductStatus.Synced:
        //             return "synced";
        //         case SyncProductStatus.UnSynced:
        //             return "unsynced";
        //         case SyncProductStatus.Ignored:
        //             return "ignored";
        //         case SyncProductStatus.Imported:
        //             return "imported";
        //         case SyncProductStatus.Discontinued:
        //             return "discontinued";
        //         case SyncProductStatus.OutOfStock:
        //             return "out_of_stock";
        //         default:
        //             return "";
        //         
        //     }
        // }
    }
    
    
    public class SyncProductValidator : AbstractValidator<SyncProduct>
    {
        public SyncProductValidator()
        {
            // RuleFor(x => x.Status)
            //     .NotEmpty()
            //     .WithMessage("Status must not be empty");
        }
    }
}