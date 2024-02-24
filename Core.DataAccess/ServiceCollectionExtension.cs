using Core.DataAccess.Contracts;
using Core.DataAccess.Repository;

namespace Microsoft.Extensions.DependencyInjection;

public static class ServiceCollectionExtension
{
    public static IServiceCollection AddServicesForEFCore(
        this IServiceCollection services)
    {
        if (services == null)
        {
            throw new ArgumentNullException(nameof(services));
        }

        services.AddTransient<IProductRepository, ProductRepository>();

        return services;
    }
}