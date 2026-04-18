using LibraryBlazorApp.Domain.Models;
using Microsoft.AspNetCore.Identity;

namespace LibraryBlazorApp.Infrastructure.Identity;

public class ApplicationUser : IdentityUser
{
    public Client? Client { get; set; } 
}
