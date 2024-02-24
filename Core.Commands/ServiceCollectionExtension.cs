using Core.Commands.CommandHandler;
using Core.Commands.Contracts;
using Microsoft.Extensions.DependencyInjection;

namespace Core.Commands;

public static class ServiceCollectionExtension
{
    public static IServiceCollection AddServicesForCommands(this IServiceCollection services)
    {
        if (services == null)
        {
            throw new ArgumentNullException(nameof(services));
        }

        services.AddTransient<IAddProductCommandHandler, AddProductCommandHandler>();

        return services;
    }
}