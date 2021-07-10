using Microsoft.Extensions.DependencyInjection;
using System;

namespace GeonorgeAddressSearch
{
    public static class ServiceExtension
    {
        public static IServiceCollection AddGeonorgeAddressSearch(this IServiceCollection services)
        {
            return services.AddGeonorgeAddressSearchServices();
        }

        public static IServiceCollection AddGeonorgeAddressSearch(this IServiceCollection services, Action<GeonorgeAddressSearchOptions> geonorgeSearchOptions)
        {
            services.Configure(geonorgeSearchOptions);

            return services.AddGeonorgeAddressSearchServices();
        }

        public static IServiceCollection AddGeonorgeAddressSearch(this IServiceCollection services, GeonorgeAddressSearchOptions geonorgeSearchOptions)
        {
            services
                .AddOptions<GeonorgeAddressSearchOptions>()
                .Configure(options => options.BaseUrl = geonorgeSearchOptions.BaseUrl);

            return services.AddGeonorgeAddressSearchServices();
        }

        private static IServiceCollection AddGeonorgeAddressSearchServices(this IServiceCollection services)
        {
            services.AddHttpClient<IGeonorgeAddressSearchService, GeonorgeAddressSearchService>();

            return services;
        }
    }
}
