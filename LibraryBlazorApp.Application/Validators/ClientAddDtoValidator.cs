using FluentValidation;
using LibraryBlazorApp.Application.Dto;

namespace LibraryBlazorApp.Application.Validators;

public class ClientAddDtoValidator : AbstractValidator<ClientAddAdminDto>
{
    public ClientAddDtoValidator()
    {
        RuleFor(c => c.Name)
            .NotNull().WithMessage("Name is required.")
            .NotEmpty().WithMessage("Name is required.")
            .MinimumLength(1).WithMessage("Min length is 1 letter.")
            .MaximumLength(100).WithMessage("Max length is 100 letters.");

        RuleFor(c => c.Surname)
            .MaximumLength(100).WithMessage("Max length is 100 letters.");

        RuleFor(c => c.Email)
            .MaximumLength(100).WithMessage("Max length is 100 letters.");

        RuleFor(c => c.PhoneNumber)
            .MaximumLength(100).WithMessage("Max length is 100 letters.");

        RuleFor(c => c.City)
            .NotNull().WithMessage("City is required.")
            .NotEmpty().WithMessage("City is required.")
            .MinimumLength(1).WithMessage("Min length is 1 letter.")
            .MaximumLength(200).WithMessage("Max length is 200 letters.");

        RuleFor(c => c.Street)
            .NotNull().WithMessage("Street is required.")
            .NotEmpty().WithMessage("Street is required.")
            .MinimumLength(1).WithMessage("Min length is 1 letter.")
            .MaximumLength(200).WithMessage("Max length is 200 letters.");

        RuleFor(c => c.PostalCode)
            .NotNull().WithMessage("Postal Code is required.")
            .NotEmpty().WithMessage("Postal Code is required.")
            .MinimumLength(1).WithMessage("Min length is 1 letter.")
            .MaximumLength(10).WithMessage("Max length is 10 letters.");

        RuleFor(c => c.Country)
            .NotNull().WithMessage("Country Code is required.")
            .NotEmpty().WithMessage("Country Code is required.")
            .MinimumLength(1).WithMessage("Min length is 1 letter.")
            .MaximumLength(190).WithMessage("Max length is 190 letters.");
    }
    public Func<object, string, Task<IEnumerable<string>>> ValidateValue => async (model, propertyName) =>
    {
        var result = await ValidateAsync(ValidationContext<ClientAddAdminDto>.CreateWithOptions((ClientAddAdminDto)model, x => x.IncludeProperties(propertyName)));
        if (result.IsValid)
            return Array.Empty<string>();
        return result.Errors.Select(e => e.ErrorMessage);
    };
}
