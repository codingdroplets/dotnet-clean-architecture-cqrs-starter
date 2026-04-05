using CleanArchCqrs.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace CleanArchCqrs.Infrastructure.Persistence;

/// <summary>
/// Entity Framework Core DbContext for the application.
/// Full version includes configuration, relationships, indexes, and seeding.
/// </summary>
public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

    public DbSet<Product> Products => Set<Product>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        // TODO: Full configuration with Fluent API - see Patreon version
    }
}
