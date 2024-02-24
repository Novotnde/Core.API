using Core.Query.Contracts;
using Core.Query.Query;
using Core.Query.QueryHandler;
using Microsoft.Extensions.DependencyInjection;

namespace Core.Query;

public static class ServiceCollectionExtension
{
    public static IServiceCollection AddServicesForQueries(
        this IServiceCollection services)
    {
        if (services == null)
        {
            throw new ArgumentNullException(nameof(services));
        }

        services.AddTransient<IGetProductQueryHandler, GetProductQueryHandler>();

        return services;
    }
}