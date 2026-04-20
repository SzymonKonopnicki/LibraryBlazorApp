using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace LibraryBlazorApp.Infrastructure.Data.Configurations.DataSeed;

public static class RolesSeedExtension
{
    public static void SeedRoles(this ModelBuilder modelBuilder)
    {

        modelBuilder.Entity<IdentityRole>().HasData(
            new IdentityRole
            {
                Id = "068120C4-B482-4D33-B59B-F8912CF44246",
                Name = "Admin",
                NormalizedName = "ADMIN",
                ConcurrencyStamp = "86729487-68B0-4A6A-9717-4828FB497621"
            },
            new IdentityRole
            {
                Id = "31BEC81A-71F6-4799-90A6-3A82D9888E95",
                Name = "User",
                NormalizedName = "USER",
                ConcurrencyStamp = "6884FB5C-A3FD-4ACD-95F6-89247943436E"
            }
        );

    }

}
