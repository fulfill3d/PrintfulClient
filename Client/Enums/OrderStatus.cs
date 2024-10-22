using System.ComponentModel;

namespace Client.Enums
{
    public enum OrderStatus
    {
        [Description("draft")]
        Draft,    // order is not submitted for fulfillment
        
        [Description("failed")]
        Failed,   // order was submitted for fulfillment but was not accepted because of an error
        
        [Description("pending")]
        Pending,  // order has been submitted for fulfillment
        
        [Description("canceled")]
        Canceled, // order is canceled
        
        [Description("onhold")]
        OnHold,   // order has encountered a problem during the fulfillment
        
        [Description("partial")]
        Partial,  // order is partially fulfilled
        
        [Description("fulfilled")]
        Fulfilled // all items are shipped
    }
}