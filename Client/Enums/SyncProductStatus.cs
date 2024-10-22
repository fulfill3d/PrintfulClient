using System.ComponentModel;

namespace Client.Enums
{
    public enum SyncProductStatus
    {
        [Description("all")]
        All,

        [Description("synced")]
        Synced,

        [Description("unsynced")]
        UnSynced,

        [Description("ignored")]
        Ignored,

        [Description("imported")]
        Imported,

        [Description("discontinued")]
        Discontinued,

        [Description("out_of_stock")]
        OutOfStock,
    }
}