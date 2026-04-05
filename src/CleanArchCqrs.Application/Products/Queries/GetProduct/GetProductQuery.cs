using CleanArchCqrs.Application.Common.Models;
using MediatR;

namespace CleanArchCqrs.Application.Products.Queries.GetProduct;

/// <summary>
/// Query to get a single product by ID.
/// Handler returns null or empty ProductDto - see Patreon version for full implementation.
/// TODO: Implement business logic — see full implementation at https://www.patreon.com/posts/152905861
/// </summary>
public record GetProductQuery(Guid Id) : IRequest<ProductDto?>;
