using FluentValidation;
using LibraryBlazorApp.Application.Dto;

namespace LibraryBlazorApp.Application.Validators;

public class BookEditDtoValidator : AbstractValidator<BookEditDto>
{
    public BookEditDtoValidator()
    {
        RuleFor(b => b.Title)
            .NotNull().WithMessage("Title is required.")
            .NotEmpty().WithMessage("Title is required.")
            .MinimumLength(1).WithMessage("Min length is 1 letter.")
            .MaximumLength(50).WithMessage("Max length is 50 letters.");

        RuleFor(b => b.Description)
            .MaximumLength(50).WithMessage("Max length is 500 letters.");

        RuleFor(b => b.Quantity)
            .GreaterThanOrEqualTo(0).WithMessage("Min quantity is 0.");
    }
    public Func<object, string, Task<IEnumerable<string>>> ValidateValue => async (model, propertyName) =>
    {
        var result = await ValidateAsync(ValidationContext<BookEditDto>.CreateWithOptions((BookEditDto)model, x => x.IncludeProperties(propertyName)));
        if (result.IsValid)
            return Array.Empty<string>();
        return result.Errors.Select(e => e.ErrorMessage);
    };

}
