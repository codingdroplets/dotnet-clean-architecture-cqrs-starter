using CleanArchCqrs.Application.Common.Models;
using MediatR;

namespace CleanArchCqrs.Application.Products.Queries.GetProducts;

/// <summary>
/// Query to get all products with optional pagination.
/// Handler returns empty PagedResult - see Patreon version for full implementation with search and pagination.
/// TODO: Implement business logic — see full implementation at https://www.patreon.com/posts/152905861
/// </summary>
public record GetProductsQuery(
    int? PageNumber = null,
    int? PageSize = null,
    string? SearchTerm = null
) : IRequest<PagedResult<ProductDto>>;
