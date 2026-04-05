namespace CleanArchCqrs.Domain.Exceptions;

/// <summary>
/// Base domain exception for domain-related errors.
/// In the full Patreon version, this includes additional domain-specific exceptions.
/// </summary>
public class DomainException : Exception
{
    public DomainException() : base() { }
    public DomainException(string message) : base(message) { }
    public DomainException(string message, Exception innerException) : base(message, innerException) { }
}
