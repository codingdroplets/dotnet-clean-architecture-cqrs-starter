using CleanArchCqrs.Application.Common.Models;
using MediatR;

namespace CleanArchCqrs.Application.Products.Commands.UpdateProduct;

/// <summary>
/// Command to update an existing product.
/// Handler returns Unit.Value - see Patreon version for full implementation with business logic.
/// TODO: Implement business logic — see full implementation at https://www.patreon.com/posts/152905861
/// </summary>
public record UpdateProductCommand(
    Guid Id,
    string Name,
    string Description,
    decimal Price,
    int StockQuantity
) : IRequest<Unit>;
