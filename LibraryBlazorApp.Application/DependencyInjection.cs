using LibraryBlazorApp.Application.Handlers;
using LibraryBlazorApp.Application.Interfaces;
using LibraryBlazorApp.Application.Services.Maps;
using Microsoft.Extensions.DependencyInjection;

namespace LibraryBlazorApp.Application;

public static class DependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        services.AddScoped<IBookHandler, BookHandler>();

        return services;
    }
}
