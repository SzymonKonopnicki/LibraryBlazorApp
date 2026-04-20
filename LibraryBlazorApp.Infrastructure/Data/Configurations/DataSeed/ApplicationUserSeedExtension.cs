using LibraryBlazorApp.Infrastructure.Identity;
using Microsoft.EntityFrameworkCore;

namespace LibraryBlazorApp.Infrastructure.Data.Configurations.DataSeed;

public static class ApplicationUserSeedExtension
{
    public static void SeedAppUser(this ModelBuilder modelBuilder, string[] guidTab)
    {
        //Client: client1@library.com is Administrator
        //Password: Test123!
        modelBuilder.Entity<ApplicationUser>().HasData(
            new ApplicationUser
            {
                Id = guidTab[0],
                UserName = "client1@library.com",
                NormalizedUserName = "CLIENT1@LIBRARY.COM",
                Email = "client1@library.com",
                NormalizedEmail = "CLIENT1@LIBRARY.COM",
                EmailConfirmed = true,
                PasswordHash = "AQAAAAIAAYagAAAAEKD/HLWMXPpfstJQVV72WSuN0Y4ep3TYG/qS9EGGtqM6ldvU7oe3wbMVx9gkwuzOrA==",
                SecurityStamp = "STATIC-STAMP-1",
                ConcurrencyStamp = "STATIC-CONCURRENCY-1"
            },
            new ApplicationUser
            {
                Id = guidTab[1],
                UserName = "client2@library.com",
                NormalizedUserName = "CLIENT2@LIBRARY.COM",
                Email = "client2@library.com",
                NormalizedEmail = "CLIENT2@LIBRARY.COM",
                EmailConfirmed = true,
                PasswordHash = "AQAAAAIAAYagAAAAEKD/HLWMXPpfstJQVV72WSuN0Y4ep3TYG/qS9EGGtqM6ldvU7oe3wbMVx9gkwuzOrA==",
                SecurityStamp = "STATIC-STAMP-2",
                ConcurrencyStamp = "STATIC-CONCURRENCY-2"
            },
            new ApplicationUser
            {
                Id = guidTab[2],
                UserName = "client3@library.com",
                NormalizedUserName = "CLIENT3@LIBRARY.COM",
                Email = "client3@library.com",
                NormalizedEmail = "CLIENT3@LIBRARY.COM",
                EmailConfirmed = true,
                PasswordHash = "AQAAAAIAAYagAAAAEKD/HLWMXPpfstJQVV72WSuN0Y4ep3TYG/qS9EGGtqM6ldvU7oe3wbMVx9gkwuzOrA==",
                SecurityStamp = "STATIC-STAMP-3",
                ConcurrencyStamp = "STATIC-CONCURRENCY-3"
            },
            new ApplicationUser
            {
                Id = guidTab[3],
                UserName = "client4@library.com",
                NormalizedUserName = "CLIENT4@LIBRARY.COM",
                Email = "client4@library.com",
                NormalizedEmail = "CLIENT4@LIBRARY.COM",
                EmailConfirmed = true,
                PasswordHash = "AQAAAAIAAYagAAAAEKD/HLWMXPpfstJQVV72WSuN0Y4ep3TYG/qS9EGGtqM6ldvU7oe3wbMVx9gkwuzOrA==",
                SecurityStamp = "STATIC-STAMP-4",
                ConcurrencyStamp = "STATIC-CONCURRENCY-4"
            },
            new ApplicationUser
            {
                Id = guidTab[4],
                UserName = "client5@library.com",
                NormalizedUserName = "CLIENT5@LIBRARY.COM",
                Email = "client5@library.com",
                NormalizedEmail = "CLIENT5@LIBRARY.COM",
                EmailConfirmed = true,
                PasswordHash = "AQAAAAIAAYagAAAAEKD/HLWMXPpfstJQVV72WSuN0Y4ep3TYG/qS9EGGtqM6ldvU7oe3wbMVx9gkwuzOrA==",
                SecurityStamp = "STATIC-STAMP-5",
                ConcurrencyStamp = "STATIC-CONCURRENCY-5"
            },
            new ApplicationUser
            {
                Id = guidTab[5],
                UserName = "client6@library.com",
                NormalizedUserName = "CLIENT6@LIBRARY.COM",
                Email = "client6@library.com",
                NormalizedEmail = "CLIENT6@LIBRARY.COM",
                EmailConfirmed = true,
                PasswordHash = "AQAAAAIAAYagAAAAEKD/HLWMXPpfstJQVV72WSuN0Y4ep3TYG/qS9EGGtqM6ldvU7oe3wbMVx9gkwuzOrA==",
                SecurityStamp = "STATIC-STAMP-6",
                ConcurrencyStamp = "STATIC-CONCURRENCY-6"
            },
            new ApplicationUser
            {
                Id = guidTab[6],
                UserName = "client7@library.com",
                NormalizedUserName = "CLIENT7@LIBRARY.COM",
                Email = "client7@library.com",
                NormalizedEmail = "CLIENT7@LIBRARY.COM",
                EmailConfirmed = true,
                PasswordHash = "AQAAAAIAAYagAAAAEKD/HLWMXPpfstJQVV72WSuN0Y4ep3TYG/qS9EGGtqM6ldvU7oe3wbMVx9gkwuzOrA==",
                SecurityStamp = "STATIC-STAMP-7",
                ConcurrencyStamp = "STATIC-CONCURRENCY-7"
            },
            new ApplicationUser
            {
                Id = guidTab[7],
                UserName = "client8@library.com",
                NormalizedUserName = "CLIENT8@LIBRARY.COM",
                Email = "client8@library.com",
                NormalizedEmail = "CLIENT8@LIBRARY.COM",
                EmailConfirmed = true,
                PasswordHash = "AQAAAAIAAYagAAAAEKD/HLWMXPpfstJQVV72WSuN0Y4ep3TYG/qS9EGGtqM6ldvU7oe3wbMVx9gkwuzOrA==",
                SecurityStamp = "STATIC-STAMP-8",
                ConcurrencyStamp = "STATIC-CONCURRENCY-8"
            },
            new ApplicationUser
            {
                Id = guidTab[8],
                UserName = "client9@library.com",
                NormalizedUserName = "CLIENT9@LIBRARY.COM",
                Email = "client9@library.com",
                NormalizedEmail = "CLIENT9@LIBRARY.COM",
                EmailConfirmed = true,
                PasswordHash = "AQAAAAIAAYagAAAAEKD/HLWMXPpfstJQVV72WSuN0Y4ep3TYG/qS9EGGtqM6ldvU7oe3wbMVx9gkwuzOrA==",
                SecurityStamp = "STATIC-STAMP-9",
                ConcurrencyStamp = "STATIC-CONCURRENCY-9"
            },
            new ApplicationUser
            {
                Id = guidTab[9],
                UserName = "client10@library.com",
                NormalizedUserName = "CLIENT10@LIBRARY.COM",
                Email = "client10@library.com",
                NormalizedEmail = "CLIENT10@LIBRARY.COM",
                EmailConfirmed = true,
                PasswordHash = "AQAAAAIAAYagAAAAEKD/HLWMXPpfstJQVV72WSuN0Y4ep3TYG/qS9EGGtqM6ldvU7oe3wbMVx9gkwuzOrA==",
                SecurityStamp = "STATIC-STAMP-10",
                ConcurrencyStamp = "STATIC-CONCURRENCY-10"
            }
        );

    }

}
