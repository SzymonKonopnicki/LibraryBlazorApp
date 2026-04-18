using LibraryBlazorApp.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace LibraryBlazorApp.Infrastructure.Data.Configurations.DataSeed;

public static class ClientSeedExtension
{
    public static void SeedClients(this ModelBuilder modelBuilder, string[] guidTab)
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

        modelBuilder.Entity<Client>().HasData(
            new Client
            {
                Id = 1,
                IdentityUserId = guidTab[0],
                CreatedAt = seedDate[0],
                UpdatedAt = seedDate[0],
                Name = "Adam",
                Surname = "Nowicki",
            },
            new Client
            {
                Id = 2,
                IdentityUserId = guidTab[1],
                CreatedAt = seedDate[1],
                UpdatedAt = seedDate[1],
                Name = "Ewa",
                Surname = "Kaczmarek",
            },
            new Client
            {
                Id = 3,
                IdentityUserId = guidTab[2],
                CreatedAt = seedDate[2],
                UpdatedAt = seedDate[2],
                Name = "Piotr",
                Surname = "Mazur",
            },
            new Client
            {
                Id = 4,
                IdentityUserId = guidTab[3],
                CreatedAt = seedDate[3],
                UpdatedAt = seedDate[3],
                Name = "Karolina",
                Surname = "Dąbrowska",
            },
            new Client
            {
                Id = 5,
                IdentityUserId = guidTab[4],
                CreatedAt = seedDate[4],
                UpdatedAt = seedDate[4],
                Name = "Michał",
                Surname = "Piotrowski",
            },
            new Client
            {
                Id = 6,
                IdentityUserId = guidTab[5],
                CreatedAt = seedDate[5],
                UpdatedAt = seedDate[5],
                Name = "Natalia",
                Surname = "Grabowska",
            },
            new Client
            {
                Id = 7,
                IdentityUserId = guidTab[6],
                CreatedAt = seedDate[6],
                UpdatedAt = seedDate[6],
                Name = "Krzysztof",
                Surname = "Pawlak",
            },
            new Client
            {
                Id = 8,
                IdentityUserId = guidTab[7],
                CreatedAt = seedDate[7],
                UpdatedAt = seedDate[7],
                Name = "Magdalena",
                Surname = "Michalska",
            },
            new Client
            {
                Id = 9,
                IdentityUserId = guidTab[8],
                CreatedAt = seedDate[8],
                UpdatedAt = seedDate[8],
                Name = "Paweł",
                Surname = "Król",
            },
            new Client
            {
                Id = 10,
                IdentityUserId = guidTab[9],
                CreatedAt = seedDate[9],
                UpdatedAt = seedDate[9],
                Name = "Agnieszka",
                Surname = "Wieczorek",
            }
        );
    }
}
