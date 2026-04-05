using CleanArchCqrs.Domain.Entities;
using CleanArchCqrs.Domain.Interfaces;
using CleanArchCqrs.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace CleanArchCqrs.Infrastructure.Repositories;

/// <summary>
/// EF Core implementation of IProductRepository.
/// All methods throw NotImplementedException - this is a stub only.
/// Full implementation with efficient queries, AsNoTracking, search, pagination is in Patreon version.
/// </summary>
public class ProductRepository : IProductRepository
{
    private readonly AppDbContext _context;

    public ProductRepository(AppDbContext context)
    {
        _context = context;
    }

    public Task<Product?> GetByIdAsync(Guid id, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException("See full implementation at https://www.patreon.com/posts/152905861");
    }

    public Task<IReadOnlyList<Product>> GetAllAsync(CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException("See full implementation at https://www.patreon.com/posts/152905861");
    }

    public Task<IReadOnlyList<Product>> SearchAsync(string searchTerm, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException("See full implementation at https://www.patreon.com/posts/152905861");
    }

    public Task<PagedResult<Product>> GetPagedAsync(int pageNumber, int pageSize, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException("See full implementation at https://www.patreon.com/posts/152905861");
    }

    public Task AddAsync(Product product, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException("See full implementation at https://www.patreon.com/posts/152905861");
    }

    public Task UpdateAsync(Product product, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException("See full implementation at https://www.patreon.com/posts/152905861");
    }

    public Task DeleteAsync(Guid id, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException("See full implementation at https://www.patreon.com/posts/152905861");
    }

    public Task<bool> ExistsAsync(Guid id, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException("See full implementation at https://www.patreon.com/posts/152905861");
    }

    public Task<int> CountAsync(CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException("See full implementation at https://www.patreon.com/posts/152905861");
    }
}
