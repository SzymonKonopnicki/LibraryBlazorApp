using LibraryBlazorApp.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace LibraryBlazorApp.Infrastructure.Data.Configurations.DataSeed;

public static class AddressSeedExtension
{
    public static void SeedAddresses(this ModelBuilder modelBuilder)
    {
        var seedDate = new[]
        {
            new DateTime(2024, 3, 15, 0, 0, 0, DateTimeKind.Utc),
            new DateTime(2023, 7, 22, 0, 0, 0, DateTimeKind.Utc),
            new DateTime(2022, 11, 5, 0, 0, 0, DateTimeKind.Utc),
            new DateTime(2021, 4, 19, 0, 0, 0, DateTimeKind.Utc),
            new DateTime(2020, 9, 3, 0, 0, 0, DateTimeKind.Utc),
            new DateTime(2022, 2, 28, 0, 0, 0, DateTimeKind.Utc),
            new DateTime(2021, 6, 11, 0, 0, 0, DateTimeKind.Utc),
            new DateTime(2020, 12, 24, 0, 0, 0, DateTimeKind.Utc),
            new DateTime(2001, 5, 30, 0, 0, 0, DateTimeKind.Utc),
            new DateTime(2020, 8, 17, 0, 0, 0, DateTimeKind.Utc)
        };

        modelBuilder.Entity<Address>().HasData(
            new Address
            {
                Id = 1,
                CreatedAt = seedDate[0],
                City = "Warszawa",
                Street = "Kwiatowa 1",
                PostalCode = "00-001",
                Country = "Polska",
                ClientId = 1
            },
            new Address
            {
                Id = 2,
                CreatedAt = seedDate[1],
                City = "Kraków",
                Street = "Słoneczna 5",
                PostalCode = "30-002",
                Country = "Polska",
                ClientId = 2
            },
            new Address
            {
                Id = 3,
                CreatedAt = seedDate[2],
                City = "Gdańsk",
                Street = "Leśna 10",
                PostalCode = "80-003",
                Country = "Polska",
                ClientId = 3
            },
            new Address
            {
                Id = 4,
                CreatedAt = seedDate[3],
                City = "Wrocław",
                Street = "Polna 3",
                PostalCode = "50-004",
                Country = "Polska",
                ClientId = 4
            },
            new Address
            {
                Id = 5,
                CreatedAt = seedDate[4],
                City = "Poznań",
                Street = "Szkolna 7",
                PostalCode = "60-005",
                Country = "Polska",
                ClientId = 5
            },
            new Address
            {
                Id = 6,
                CreatedAt = seedDate[5],
                City = "Łódź",
                Street = "Ogrodowa 12",
                PostalCode = "90-006",
                Country = "Polska",
                ClientId = 6
            },
            new Address
            {
                Id = 7,
                CreatedAt = seedDate[6],
                City = "Katowice",
                Street = "Lipowa 9",
                PostalCode = "40-007",
                Country = "Polska",
                ClientId = 7
            },
            new Address
            {
                Id = 8,
                CreatedAt = seedDate[7],
                City = "Lublin",
                Street = "Brzozowa 15",
                PostalCode = "20-008",
                Country = "Polska",
                ClientId = 8
            },
            new Address
            {
                Id = 9,
                CreatedAt = seedDate[8],
                City = "Szczecin",
                Street = "Wiślana 20",
                PostalCode = "70-009",
                Country = "Polska",
                ClientId = 9
            },
            new Address
            {
                Id = 10,
                CreatedAt = seedDate[9],
                City = "Bydgoszcz",
                Street = "Zielona 8",
                PostalCode = "85-010",
                Country = "Polska",
                ClientId = 10
            }
        );
    }
}
