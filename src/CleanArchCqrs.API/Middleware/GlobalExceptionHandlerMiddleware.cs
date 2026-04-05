using System.Net.Mime;
using System.Text.Json;

namespace CleanArchCqrs.API.Middleware;

/// <summary>
/// Global exception handling middleware.
/// This is a stub - it just re-throws exceptions without RFC 7807 Problem Details mapping.
/// Full implementation with Problem Details responses is in the Patreon version.
/// </summary>
public class GlobalExceptionHandlerMiddleware
{
    private readonly RequestDelegate _next;
    private readonly ILogger<GlobalExceptionHandlerMiddleware> _logger;

    public GlobalExceptionHandlerMiddleware(RequestDelegate next, ILogger<GlobalExceptionHandlerMiddleware> logger)
    {
        _next = next;
        _logger = logger;
    }

    public async Task InvokeAsync(HttpContext context)
    {
        try
        {
            await _next(context);
        }
        catch (Exception ex)
        {
            // TODO: Map to RFC 7807 Problem Details with proper status codes and error types — see full implementation at Patreon
            _logger.LogError(ex, "An unhandled exception occurred: {Message}", ex.Message);
            throw;
        }
    }
}
