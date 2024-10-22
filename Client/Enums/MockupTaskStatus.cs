using System.ComponentModel;

namespace Client.Enums
{
    public enum MockupTaskStatus
    {
        [Description("pending")]
        Pending,
        
        [Description("completed")]
        Completed,
        
        [Description("failed")]
        Failed
    }
}