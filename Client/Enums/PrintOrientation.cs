using System.ComponentModel;

namespace Client.Enums
{
    public enum PrintOrientation
    {
        [Description("horizontal")]
        Horizontal,
        
        [Description("vertical")]
        Vertical,
        
        [Description("any")]
        Any
    }
}