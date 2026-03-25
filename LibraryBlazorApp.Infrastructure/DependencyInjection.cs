using LibraryBlazorApp.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace LibraryBlazorApp.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services)
    {
        services.AddDbContextFactory<BlazorLibraryDbContext>(options =>
            options.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=BlazorLibraryDb;Trusted_Connection=True;"));

        return services;
    }
}
