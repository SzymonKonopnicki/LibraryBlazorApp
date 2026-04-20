using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace LibraryBlazorApp.Infrastructure.Data.Configurations.DataSeed;

public static class AssignRolesSeedExtension
{
    public static void SeedAssignRoles(this ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<IdentityUserRole<string>>().HasData(
            new IdentityUserRole<string>()
            {
                RoleId = "068120C4-B482-4D33-B59B-F8912CF44246", //Admin
                UserId = "c7277975-d866-4d1c-84b0-8d9df1ac7058"
            },

            new IdentityUserRole<string>()
            {
                RoleId = "31BEC81A-71F6-4799-90A6-3A82D9888E95", //User
                UserId = "b5d8b1df-a9cf-4b2a-82ed-2e8538e1bda7"
            },
            new IdentityUserRole<string>()
            {
                RoleId = "31BEC81A-71F6-4799-90A6-3A82D9888E95", //User
                UserId = "73af2f35-a9b2-40fa-9697-c1dee8166b26"
            },
            new IdentityUserRole<string>()
            {
                RoleId = "31BEC81A-71F6-4799-90A6-3A82D9888E95", //User
                UserId = "ff49eb66-aefe-412d-8e5f-897f121f7f5d"
            },
            new IdentityUserRole<string>()
            {
                RoleId = "31BEC81A-71F6-4799-90A6-3A82D9888E95", //User
                UserId = "c1e499f0-e54f-4dad-a579-d865ed8075ef"
            },
            new IdentityUserRole<string>()
            {
                RoleId = "31BEC81A-71F6-4799-90A6-3A82D9888E95", //User
                UserId = "241b6d78-2354-46b3-8ab8-63c68bbdf631"
            },
            new IdentityUserRole<string>()
            {
                RoleId = "31BEC81A-71F6-4799-90A6-3A82D9888E95", //User
                UserId = "3a21d428-508c-4a7a-b686-2724879c764a"
            },
            new IdentityUserRole<string>()
            {
                RoleId = "31BEC81A-71F6-4799-90A6-3A82D9888E95", //User
                UserId = "39a1cce9-9123-4861-bf17-2909a7a1dff6"
            },
            new IdentityUserRole<string>()
            {
                RoleId = "31BEC81A-71F6-4799-90A6-3A82D9888E95", //User
                UserId = "be32eec5-8f03-4eaa-99d6-b2eebeebfce8"
            },
            new IdentityUserRole<string>()
            {
                RoleId = "31BEC81A-71F6-4799-90A6-3A82D9888E95", //User
                UserId = "03e12965-b521-4052-894b-e5a7ef44b9d1"
            }
        );
    }
}
