using LibraryBlazorApp.Application.Interfaces;
using LibraryBlazorApp.Application.Interfaces.Admin;
using LibraryBlazorApp.Infrastructure.Data;
using LibraryBlazorApp.Infrastructure.Identity;
using LibraryBlazorApp.Infrastructure.Repositories.Commands.Admin;
using LibraryBlazorApp.Infrastructure.Repositories.Querie;
using LibraryBlazorApp.Infrastructure.Repositories.Queries;
using LibraryBlazorApp.Infrastructure.Repositories.Queries.Admin;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace LibraryBlazorApp.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services, string connectionString)
    {
        services.AddDbContextFactory<BlazorLibraryDbContext>(options =>
            options.UseSqlServer(connectionString));

        services.AddAuthentication(options =>
        {
            options.DefaultScheme = IdentityConstants.ApplicationScheme;
            options.DefaultSignInScheme = IdentityConstants.ExternalScheme;
        })
        .AddIdentityCookies();

        services.AddIdentityCore<ApplicationUser>(options => options.SignIn.RequireConfirmedAccount = true)
            .AddEntityFrameworkStores<BlazorLibraryDbContext>()
            .AddSignInManager()
            .AddDefaultTokenProviders();

        services.AddScoped<IBookQuery, BookQuery>();
        services.AddScoped<ILibraryCardQuery, LibraryCardQuery>();

        services.AddScoped<IAdminBookCommand, AdminBookCommand>();
        services.AddScoped<IAuthorAdminQuery, AdminAuthorQuery>();
        services.AddScoped<IAdminAuthorCommand, AdminAuthorCommand>();
        services.AddScoped<IAdminClientQuery, AdminClientQuery>();
        services.AddScoped<IAdminClientCommand, AdminClientCommand>();
        services.AddScoped<IAdminLibraryCardQuery, AdminLibraryCardQuery>();
        services.AddScoped<IAdminLibraryCardCommand, AdminLibraryCardCommand>();
        services.AddScoped<IAdminLoanCommand, AdminLoanCommand>();

        return services;
    }
}
