using LibraryBlazorApp.Infrastructure.Identity;
using LibraryBlazorApp.UI.Components.Account;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Identity;

namespace LibraryBlazorApp.UI;

public static class IdentityUiRegistration
{
    public static IServiceCollection AddIdentityUi(this IServiceCollection services)
    {
        services.AddCascadingAuthenticationState();

        services.AddScoped<IdentityUserAccessor>();
        services.AddScoped<IdentityRedirectManager>();

        services.AddSingleton<IEmailSender<ApplicationUser>, IdentityNoOpEmailSender>();

        return services;
    }
}
