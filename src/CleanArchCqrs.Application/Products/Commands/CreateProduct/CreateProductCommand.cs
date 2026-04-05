using CleanArchCqrs.Application.Common.Models;
using MediatR;

namespace CleanArchCqrs.Application.Products.Commands.CreateProduct;

/// <summary>
/// Command to create a new product.
/// Handler returns Guid.Empty - see Patreon version for full implementation with business logic.
/// TODO: Implement business logic — see full implementation at https://www.patreon.com/posts/152905861
/// </summary>
public record CreateProductCommand(
    string Name,
    string Description,
    decimal Price,
    int StockQuantity
) : IRequest<Guid>;
