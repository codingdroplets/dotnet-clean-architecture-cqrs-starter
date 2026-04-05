using System.Text.Json.Serialization;
using CleanArchCqrs.Domain.Common;

namespace CleanArchCqrs.Domain.Entities;

/// <summary>
/// Product entity - represents a product in the catalog.
/// This is a stub with only properties - see Patreon version for full domain logic including validation, factory methods, and domain methods.
/// </summary>
public class Product : BaseEntity
{
    /// <summary>
    /// Product name - See Patreon version for domain validation (required, max length, etc.)
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// Product description - See Patreon version for domain validation (max length, etc.)
    /// </summary>
    [JsonPropertyName("description")]
    public string Description { get; set; } = string.Empty;

    /// <summary>
    /// Price - See Patreon version for domain validation (must be >= 0)
    /// </summary>
    [JsonPropertyName("price")]
    public decimal Price { get; set; }

    /// <summary>
    /// Stock quantity - See Patreon version for domain validation (must be >= 0)
    /// </summary>
    [JsonPropertyName("stockQuantity")]
    public int StockQuantity { get; set; }

    /// <summary>
    /// Creation timestamp - See Patreon version for domain validation (auto-set)
    /// </summary>
    [JsonPropertyName("createdAt")]
    public DateTime CreatedAt { get; set; }

    /// <summary>
    /// Last update timestamp - See Patreon version for domain validation (auto-set)
    /// </summary>
    [JsonPropertyName("updatedAt")]
    public DateTime? UpdatedAt { get; set; }
}
