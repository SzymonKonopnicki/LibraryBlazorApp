using FluentValidation;
using LibraryBlazorApp.Application.Dto;
using LibraryBlazorApp.Application.Dto.Author;
using LibraryBlazorApp.Application.Handlers;
using LibraryBlazorApp.Application.Handlers.Admin;
using LibraryBlazorApp.Application.Interfaces;
using LibraryBlazorApp.Application.Interfaces.Admin;
using LibraryBlazorApp.Application.Validators;
using Microsoft.Extensions.DependencyInjection;

namespace LibraryBlazorApp.Application;

public static class DependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        services.AddScoped<IBookHandler, BookHandler>();
        services.AddScoped<ILibraryCardHandler, LibraryCardHandler>();

        services.AddScoped<IAdminBookHandler, AdminBookHandler>();
        services.AddScoped<IAdminAuthorHandler, AdminAuthorHandler>();
        services.AddScoped<IAdminClientHandler, AdminClientHandler>();
        services.AddScoped<IAdminLibraryCardHandler, AdminLibraryCardHandler>();

        services.AddSingleton<IValidator<BookEditDto>, BookEditDtoValidator>();
        services.AddSingleton<IValidator<BookAddDto>, BookAddDtoValidator>();
        services.AddSingleton<IValidator<AuthorAddDto>, AuthorAddDtoValidator>();
        services.AddSingleton<IValidator<AuthorEditAdminDto>, AuthorEditAdminDtoValidator>();
        services.AddSingleton<IValidator<ClientAddAdminDto>, ClientAddDtoValidator>();
        services.AddSingleton<IValidator<ClientEditAdminDto>, ClientEditDtoValidator>();

        return services;
    }
}
