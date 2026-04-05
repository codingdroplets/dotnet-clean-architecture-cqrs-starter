using CleanArchCqrs.Application.Products.Commands.CreateProduct;
using FluentValidation;

namespace CleanArchCqrs.Application.Products.Validators;

/// <summary>
/// Validator for CreateProductCommand.
/// This is an empty validator with no rules - stub only.
/// TODO: Add validation rules — see full implementation at https://www.patreon.com/posts/152905861
/// </summary>
public class CreateProductCommandValidator : AbstractValidator<CreateProductCommand>
{
    public CreateProductCommandValidator()
    {
        // TODO: Add validation rules for Name (required, max length), Price (>= 0), StockQuantity (>= 0), etc.
        // See full implementation at Patreon
    }
}
