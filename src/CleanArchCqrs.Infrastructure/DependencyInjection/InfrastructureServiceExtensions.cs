using CleanArchCqrs.Domain.Interfaces;
using CleanArchCqrs.Infrastructure.Persistence;
using CleanArchCqrs.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace CleanArchCqrs.Infrastructure.DependencyInjection;

/// <summary>
/// Extension methods for registering Infrastructure layer services.
/// </summary>
public static class InfrastructureServiceExtensions
{
    public static IServiceCollection AddInfrastructureServices(this IServiceCollection services, string? connectionString = null)
    {
        // InMemory database for demo - full version uses SQL Server with real connection string
        services.AddDbContext<AppDbContext>(options =>
        {
            options.UseInMemoryDatabase("CleanArchCqrsDb");
        });

        // Repository
        services.AddScoped<IProductRepository, ProductRepository>();

        return services;
    }
}
