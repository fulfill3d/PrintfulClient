using System.ComponentModel;

namespace Client.Enums
{
    public enum PrintFillMode
    {
        [Description("cover")]
        Cover,
        
        [Description("fill")]
        Fill,
        
        [Description("fit")]
        Fit
    }
}