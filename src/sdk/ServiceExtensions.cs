using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using sdk.util;

namespace sdk
{
    public static class ServiceExtensions
    {
        public static void AddSFCityService(this IServiceCollection services, IConfiguration configuration)
        {
            services.Configure<SFCityOptions>(configuration.GetSection(nameof(SFCityOptions)));
            services.AddScoped<ISFCityApi, SFCityApi>();
        }
    }
}
