using CleanArchitecture.Application.Common.Interfaces;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CleanArchitecture.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructureServices(this IServiceCollection services, IConfiguration configuration)
    {
        // Register services
        services.AddScoped(typeof(IGenericRepository<>), typeof(Repositories.GenericRepository<>));
        
        // Other infrastructure service registrations...
        
        return services;
    }
}
