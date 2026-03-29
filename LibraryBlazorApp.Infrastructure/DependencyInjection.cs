using LibraryBlazorApp.Application.Interfaces;
using LibraryBlazorApp.Infrastructure.Data;
using LibraryBlazorApp.Infrastructure.Repositories.Querie;
using LibraryBlazorApp.Infrastructure.Repositories.Queries;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace LibraryBlazorApp.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services)
    {
        services.AddDbContextFactory<BlazorLibraryDbContext>(options =>
            options.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=BlazorLibraryDb;Trusted_Connection=True;"));

        services.AddScoped<IBookQuery, BookQuery>();
        services.AddScoped<IBookAdminCommand, BookAdminCommand>();
        services.AddScoped<IAuthorAdminQuery, AuthorAdminQuery>();

        return services;
    }
}
