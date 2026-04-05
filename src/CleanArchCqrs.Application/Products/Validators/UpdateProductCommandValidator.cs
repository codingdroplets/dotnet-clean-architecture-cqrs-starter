using CleanArchCqrs.Application.Products.Commands.UpdateProduct;
using FluentValidation;

namespace CleanArchCqrs.Application.Products.Validators;

/// <summary>
/// Validator for UpdateProductCommand.
/// This is an empty validator with no rules - stub only.
/// TODO: Add validation rules — see full implementation at https://www.patreon.com/posts/152905861
/// </summary>
public class UpdateProductCommandValidator : AbstractValidator<UpdateProductCommand>
{
    public UpdateProductCommandValidator()
    {
        // TODO: Add validation rules - Id (required), Name (required), Price (>= 0), etc.
        // See full implementation at Patreon
    }
}
