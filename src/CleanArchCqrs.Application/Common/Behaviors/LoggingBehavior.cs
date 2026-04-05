using System.Text.Json;
using MediatR;
using Microsoft.Extensions.Logging;

namespace CleanArchCqrs.Application.Common.Behaviors;

/// <summary>
/// Pipeline behavior for structured logging of requests and responses.
/// This is a stub - it just passes through without any logging.
/// TODO: Add structured logging — see full implementation at https://www.patreon.com/posts/152905861
/// </summary>
/// <typeparam name="TRequest">Request type</typeparam>
/// <typeparam name="TResponse">Response type</typeparam>
public class LoggingBehavior<TRequest, TResponse> : IPipelineBehavior<TRequest, TResponse>
    where TRequest : notnull
{
    private readonly ILogger<LoggingBehavior<TRequest, TResponse>> _logger;

    public LoggingBehavior(ILogger<LoggingBehavior<TRequest, TResponse>> logger)
    {
        _logger = logger;
    }

    public async Task<TResponse> Handle(TRequest request, RequestHandlerDelegate<TResponse> next, CancellationToken cancellationToken)
    {
        // TODO: Add structured logging with request/response, elapsed time, and correlation ID — see full implementation at Patreon
        return await next();
    }
}
