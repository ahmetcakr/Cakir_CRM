using CRM.Infrastructure.Adapters.ImageService;
using Microsoft.Extensions.DependencyInjection;

namespace CRM.Infrastructure;

public static class InfrastructureServiceRegistration
{
    public static IServiceCollection AddInfrastructureServices(this IServiceCollection services)
    {
       // services.AddScoped<ImageServiceBase, CloudinaryImageServiceAdapter>();
        return services;
    }
}
