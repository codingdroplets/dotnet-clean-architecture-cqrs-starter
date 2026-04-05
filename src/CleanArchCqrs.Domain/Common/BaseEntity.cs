namespace CleanArchCqrs.Domain.Common;

/// <summary>
/// Base entity with ID - all domain entities inherit from this.
/// In the full Patreon version, this includes additional audit fields and domain event handling.
/// </summary>
public abstract class BaseEntity
{
    public Guid Id { get; set; }
}
