using System.ComponentModel;

namespace Client.Enums
{
    public enum FileProcessingStatus
    {
        [Description("ok")]
        Ok,
        
        [Description("waiting")]
        Waiting,
        
        [Description("failed")]
        Failed,
    }
}