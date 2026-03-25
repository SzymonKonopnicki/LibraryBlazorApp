using LibraryBlazorApp.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace LibraryBlazorApp.Infrastructure.Data.Configurations.DataSeed;

public static class LibraryCardSeedExtension
{
    public static void SeedLibraryCards(this ModelBuilder modelBuilder)
    {
        var seedDates = new[]
        {
            new DateTime(2023, 1, 15, 0, 0, 0, DateTimeKind.Utc),
            new DateTime(2022, 3, 10, 0, 0, 0, DateTimeKind.Utc),
            new DateTime(2021, 5, 22, 0, 0, 0, DateTimeKind.Utc),
            new DateTime(2020, 7, 8, 0, 0, 0, DateTimeKind.Utc),
            new DateTime(2019, 9, 14, 0, 0, 0, DateTimeKind.Utc),
            new DateTime(2018, 11, 30, 0, 0, 0, DateTimeKind.Utc),
            new DateTime(2017, 2, 5, 0, 0, 0, DateTimeKind.Utc),
            new DateTime(2016, 4, 18, 0, 0, 0, DateTimeKind.Utc),
            new DateTime(2015, 6, 25, 0, 0, 0, DateTimeKind.Utc),
            new DateTime(2014, 8, 12, 0, 0, 0, DateTimeKind.Utc)
        };

        modelBuilder.Entity<LibraryCard>().HasData(
            new LibraryCard { Id = 1, ClientId = 1, CreatedAt = seedDates[0] },
            new LibraryCard { Id = 2, ClientId = 2, CreatedAt = seedDates[1] },
            new LibraryCard { Id = 3, ClientId = 3, CreatedAt = seedDates[2] },
            new LibraryCard { Id = 4, ClientId = 4, CreatedAt = seedDates[3] },
            new LibraryCard { Id = 5, ClientId = 5, CreatedAt = seedDates[4] },
            new LibraryCard { Id = 6, ClientId = 6, CreatedAt = seedDates[5] },
            new LibraryCard { Id = 7, ClientId = 7, CreatedAt = seedDates[6] },
            new LibraryCard { Id = 8, ClientId = 8, CreatedAt = seedDates[7] },
            new LibraryCard { Id = 9, ClientId = 9, CreatedAt = seedDates[8] },
            new LibraryCard { Id = 10, ClientId = 10, CreatedAt = seedDates[9] }
        );
    }
}
