using FluentValidation;
using MediatR;

namespace CleanArchCqrs.Application.Common.Behaviors;

/// <summary>
/// Pipeline behavior that automatically validates requests before processing.
/// This is a stub - it just passes through without any validation.
/// TODO: Add FluentValidation pipeline with concurrent validation — see full implementation at https://www.patreon.com/posts/152905861
/// </summary>
/// <typeparam name="TRequest">Request type that may implement IValidatableRequest</typeparam>
/// <typeparam name="TResponse">Response type</typeparam>
public class ValidationBehavior<TRequest, TResponse> : IPipelineBehavior<TRequest, TResponse>
    where TRequest : notnull
{
    private readonly IEnumerable<IValidator<TRequest>> _validators;

    public ValidationBehavior(IEnumerable<IValidator<TRequest>> validators)
    {
        _validators = validators;
    }

    public async Task<TResponse> Handle(TRequest request, RequestHandlerDelegate<TResponse> next, CancellationToken cancellationToken)
    {
        // TODO: Add FluentValidation pipeline with concurrent execution of all validators — see full implementation at Patreon
        return await next();
    }
}
