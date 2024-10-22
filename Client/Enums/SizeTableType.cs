using System.ComponentModel;

namespace Client.Enums
{
    public enum SizeTableType
    {
        [Description("measure_yourself")]
        MeasureYourself,
        
        [Description("product_measure")]
        ProductMeasure,
        
        [Description("international")]
        International
    }
}