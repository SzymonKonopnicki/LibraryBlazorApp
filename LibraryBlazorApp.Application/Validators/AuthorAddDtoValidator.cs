using FluentValidation;
using LibraryBlazorApp.Application.Dto.Author;

namespace LibraryBlazorApp.Application.Validators;

public class AuthorAddDtoValidator : AbstractValidator<AuthorAddDto>
{
    public AuthorAddDtoValidator()
    {
        RuleFor(b => b.Name)
            .NotNull().WithMessage("Name is required.")
            .NotEmpty().WithMessage("Name is required.")
            .MinimumLength(1).WithMessage("Min length is 1 letter.")
            .MaximumLength(50).WithMessage("Max length is 100 letters.");

        RuleFor(b => b.Surname)
            .MaximumLength(100).WithMessage("Max length is 100 letters.");

        RuleFor(b => b.Bio)
            .MaximumLength(250).WithMessage("Max length is 250 letters.");

        RuleFor(b => b.BirthDate)
            .LessThan(DateTime.Today.AddDays(1)).WithMessage("Date can't be in future");

        RuleFor(b => b.DeathDate)
            .LessThan(DateTime.Today.AddDays(1)).WithMessage("Date can't be in future");

        RuleFor(b => b.Nationality)
            .MaximumLength(100).WithMessage("Max length is 100 letters.");
    }
    public Func<object, string, Task<IEnumerable<string>>> ValidateValue => async (model, propertyName) =>
    {
        var result = await ValidateAsync(ValidationContext<AuthorAddDto>.CreateWithOptions((AuthorAddDto)model, x => x.IncludeProperties(propertyName)));
        if (result.IsValid)
            return Array.Empty<string>();
        return result.Errors.Select(e => e.ErrorMessage);
    };

}
