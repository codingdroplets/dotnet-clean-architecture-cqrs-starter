using MediatR;

namespace CleanArchCqrs.Application.Products.Commands.DeleteProduct;

/// <summary>
/// Command to delete a product.
/// Handler returns Unit.Value - see Patreon version for full implementation with business logic.
/// TODO: Implement business logic — see full implementation at https://www.patreon.com/posts/152905861
/// </summary>
public record DeleteProductCommand(Guid Id) : IRequest<Unit>;
