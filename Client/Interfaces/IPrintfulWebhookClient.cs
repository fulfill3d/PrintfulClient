namespace Client.Interfaces
{
    public interface IPrintfulWebhookClient
    {
        Task GetWebhookConfiguration();
        Task SetupWebhookConfiguration();
        Task DisableWebhookSupport();
    }
}