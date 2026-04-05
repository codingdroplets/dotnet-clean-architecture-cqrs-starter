using FluentValidation.Results;

namespace CleanArchCqrs.Application.Common.Exceptions;

/// <summary>
/// Exception thrown when validation fails.
/// In the full Patreon version, this includes detailed error messages and property-level failures.
/// </summary>
public class ValidationException : Exception
{
    public ValidationException() : base("One or more validation failures have occurred.") { }
    public ValidationException(IEnumerable<ValidationFailure> failures) : this()
    {
        Failures = failures ?? Enumerable.Empty<ValidationFailure>();
    }

    public IEnumerable<ValidationFailure> Failures { get; } = Enumerable.Empty<ValidationFailure>();
}
