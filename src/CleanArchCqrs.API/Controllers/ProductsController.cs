using CleanArchCqrs.Application.Common.Models;
using CleanArchCqrs.Application.Products.Commands.CreateProduct;
using CleanArchCqrs.Application.Products.Commands.DeleteProduct;
using CleanArchCqrs.Application.Products.Commands.UpdateProduct;
using CleanArchCqrs.Application.Products.Queries.GetProduct;
using CleanArchCqrs.Application.Products.Queries.GetProducts;
using CleanArchCqrs.Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CleanArchCqrs.API.Controllers;

/// <summary>
/// Products API controller - demonstrates CQRS pattern with MediatR.
/// </summary>
[ApiController]
[Route("api/[controller]")]
public class ProductsController : ControllerBase
{
    private readonly IMediator _mediator;

    public ProductsController(IMediator mediator)
    {
        _mediator = mediator;
    }

    /// <summary>
    /// Get all products with optional pagination and search.
    /// </summary>
    [HttpGet]
    public async Task<ActionResult<PagedResult<ProductDto>>> GetProducts(
        [FromQuery] int? pageNumber = null,
        [FromQuery] int? pageSize = null,
        [FromQuery] string? searchTerm = null,
        CancellationToken cancellationToken = default)
    {
        var query = new GetProductsQuery(pageNumber, pageSize, searchTerm);
        var result = await _mediator.Send(query, cancellationToken);
        return Ok(result);
    }

    /// <summary>
    /// Get a single product by ID.
    /// </summary>
    [HttpGet("{id:guid}")]
    public async Task<ActionResult<ProductDto?>> GetProduct(Guid id, CancellationToken cancellationToken = default)
    {
        var query = new GetProductQuery(id);
        var result = await _mediator.Send(query, cancellationToken);
        if (result == null)
        {
            return NotFound();
        }
        return Ok(result);
    }

    /// <summary>
    /// Create a new product.
    /// </summary>
    [HttpPost]
    public async Task<ActionResult<Guid>> CreateProduct([FromBody] CreateProductCommand command, CancellationToken cancellationToken = default)
    {
        var id = await _mediator.Send(command, cancellationToken);
        return CreatedAtAction(nameof(GetProduct), new { id }, null);
    }

    /// <summary>
    /// Update an existing product.
    /// </summary>
    [HttpPut("{id:guid}")]
    public async Task<ActionResult> UpdateProduct(Guid id, [FromBody] UpdateProductCommand command, CancellationToken cancellationToken = default)
    {
        if (id != command.Id)
        {
            return BadRequest();
        }
        await _mediator.Send(command, cancellationToken);
        return NoContent();
    }

    /// <summary>
    /// Delete a product.
    /// </summary>
    [HttpDelete("{id:guid}")]
    public async Task<ActionResult> DeleteProduct(Guid id, CancellationToken cancellationToken = default)
    {
        var command = new DeleteProductCommand(id);
        await _mediator.Send(command, cancellationToken);
        return NoContent();
    }
}
