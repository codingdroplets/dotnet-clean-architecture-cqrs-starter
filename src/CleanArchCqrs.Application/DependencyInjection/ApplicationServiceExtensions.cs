using CleanArchCqrs.Application.Common.Behaviors;
using FluentValidation;
using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace CleanArchCqrs.Application.DependencyInjection;

/// <summary>
/// Extension methods for registering Application layer services.
/// </summary>
public static class ApplicationServiceExtensions
{
    public static IServiceCollection AddApplicationServices(this IServiceCollection services)
    {
        // MediatR - register all handlers in this assembly
        services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(typeof(ApplicationServiceExtensions).Assembly));

        // Pipeline behaviors
        services.AddTransient(typeof(LoggingBehavior<,>));
        services.AddTransient(typeof(ValidationBehavior<,>));

        // FluentValidation - validators are discovered automatically
        // In full version: validators with rules are added here

        return services;
    }
}
