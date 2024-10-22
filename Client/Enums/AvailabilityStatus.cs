using System.ComponentModel;

namespace Client.Enums
{
    public enum AvailabilityStatus
    {
        [Description("in_stock")]
        InStock,
        
        [Description("stocked_on_demand")]
        StockedOnDemand,
        
        [Description("active")]
        Active,
        
        [Description("discontinued")]
        Discontinued,
        
        [Description("out_of_stock")]
        OutOfStock,
        
        [Description("temporary_out_of_stock")]
        TemporaryOutOfStock
    }
}