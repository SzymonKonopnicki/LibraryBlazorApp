using FluentValidation;
using LibraryBlazorApp.Application.Dto;
using LibraryBlazorApp.Application.Handlers;
using LibraryBlazorApp.Application.Interfaces;
using LibraryBlazorApp.Application.Validators;
using Microsoft.Extensions.DependencyInjection;

namespace LibraryBlazorApp.Application;

public static class DependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        services.AddScoped<IBookHandler, BookHandler>();
        services.AddScoped<IAdminBookHandler, AdminBookHandler>();

        services.AddSingleton<IValidator<BookEditDto>, BookEditDtoValidator>();

        return services;
    }
}
