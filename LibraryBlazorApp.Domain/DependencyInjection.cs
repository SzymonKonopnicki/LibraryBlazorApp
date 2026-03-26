using LibraryBlazorApp.Domain.Interfaces;
using LibraryBlazorApp.Domain.Policies;
using Microsoft.Extensions.DependencyInjection;

namespace LibraryBlazorApp.Domain;

public static class DependencyInjection
{
    public static IServiceCollection AddDomain(this IServiceCollection services)
    {
        services.AddScoped<IBookPolicy, BookPolicy>();

        return services;
    }

}
