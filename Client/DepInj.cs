using Client.Interfaces;
using Client.Options;
using Microsoft.Extensions.DependencyInjection;
using Polly;
using Polly.Contrib.WaitAndRetry;
using Polly.Extensions.Http;

namespace Client
{
    public static class DepInj
    {
        private static void ConfigurePrintfulAuth(
            this IServiceCollection services, 
            Action<IServiceProvider, PrintfulAuth> configureAccessToken)
        {
            services
                .AddOptions<PrintfulAuth>()
                .Configure<IServiceProvider>(
                    (options, resolver) => configureAccessToken(resolver, options)
                );
        }

        public static void ConfigurePrintfulAuth(
            this IServiceCollection services,
            Action<PrintfulAuth> configureAccessToken)
        {
            services.ConfigurePrintfulAuth((_, options) => configureAccessToken(options));
        }
        
        private static IAsyncPolicy<HttpResponseMessage> GetRetryPolicy()
        {
            var delay = Backoff.DecorrelatedJitterBackoffV2(medianFirstRetryDelay: TimeSpan.FromSeconds(1), retryCount: 3);
            var retryPolicy = HttpPolicyExtensions
                .HandleTransientHttpError()
                .OrResult(response => !response.IsSuccessStatusCode)
                .WaitAndRetryAsync(delay);
            return retryPolicy;
        }

        public static void AddPrintfulHttpClient(
            this IServiceCollection services, 
            PrintfulHttp options)
        {
            var retryPolicy = GetRetryPolicy();

            services.AddHttpClient(options.Name, client =>
                {
                    client.Timeout = TimeSpan.FromMinutes(options.Timeout);
                    client.BaseAddress = new Uri(options.BaseAddress);
                })
                .AddPolicyHandler(retryPolicy);
        }

        public static void AddPrintfulCatalogClient(this IServiceCollection services)
        {
            services.AddTransient<IPrintfulCatalogClient, PrintfulCatalogClient>();
        }

        public static void AddPrintfulFileLibraryClient(this IServiceCollection services)
        {
            services.AddTransient<IPrintfulFileLibraryClient, PrintfulFileLibraryClient>();
        }

        public static void AddPrintfulMockupClient(this IServiceCollection services)
        {
            services.AddTransient<IPrintfulMockupClient, PrintfulMockupClient>();
        }
        
        public static void AddPrintfulOAuthClient(this IServiceCollection services)
        {
            services.AddTransient<IPrintfulOAuthClient, PrintfulOAuthClient>();
        }

        public static void AddPrintfulOrdersClient(this IServiceCollection services)
        {
            services.AddTransient<IPrintfulOrdersClient, PrintfulOrdersClient>();
        }

        public static void AddPrintfulPlatformSyncClient(this IServiceCollection services)
        {
            services.AddTransient<IPrintfulPlatformSyncClient, PrintfulPlatformSyncClient>();
        }

        public static void AddPrintfulProductsClient(this IServiceCollection services)
        {
            services.AddTransient<IPrintfulProductsClient, PrintfulProductsClient>();
        }

        public static void AddPrintfulProductTemplatesClient(this IServiceCollection services)
        {
            services.AddTransient<IPrintfulProductTemplatesClient, PrintfulProductTemplatesClient>();
        }

        public static void AddPrintfulShippingRateClient(this IServiceCollection services)
        {
            services.AddTransient<IPrintfulShippingRateClient, PrintfulShippingRateClient>();
        }

        public static void AddPrintfulStateCodeClient(this IServiceCollection services)
        {
            services.AddTransient<IPrintfulStateCodeClient, PrintfulStateCodeClient>();
        }

        public static void AddPrintfulStoreInfoClient(this IServiceCollection services)
        {
            services.AddTransient<IPrintfulStoreInfoClient, PrintfulStoreInfoClient>();
        }

        public static void AddPrintfulTaxRateClient(this IServiceCollection services)
        {
            services.AddTransient<IPrintfulTaxRateClient, PrintfulTaxRateClient>();
        }

        public static void AddAllPrintfulClients(this IServiceCollection services)
        {
            services.AddPrintfulCatalogClient();
            services.AddPrintfulFileLibraryClient();
            services.AddPrintfulMockupClient();
            services.AddPrintfulOAuthClient();
            services.AddPrintfulOrdersClient();
            services.AddPrintfulPlatformSyncClient();
            services.AddPrintfulProductsClient();
            services.AddPrintfulProductTemplatesClient();
            services.AddPrintfulShippingRateClient();
            services.AddPrintfulStateCodeClient();
            services.AddPrintfulStoreInfoClient();
            services.AddPrintfulTaxRateClient();
        }
    }
}