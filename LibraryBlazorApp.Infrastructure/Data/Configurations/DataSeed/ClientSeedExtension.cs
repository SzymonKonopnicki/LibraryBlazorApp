using LibraryBlazorApp.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryBlazorApp.Infrastructure.Data.Configurations.DataSeed;

public static class ClientSeedExtension
{
    public static void SeedClients(this ModelBuilder modelBuilder)
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
                CreatedAt = seedDate[0],
                Name = "Adam",
                Surname = "Nowicki",
                Email = "adam.nowicki@example.com",
                PhoneNumber = "500100200"
            },
            new Client
            {
                Id = 2,
                CreatedAt = seedDate[1],
                Name = "Ewa",
                Surname = "Kaczmarek",
                Email = "ewa.kaczmarek@example.com",
                PhoneNumber = "501200300"
            },
            new Client
            {
                Id = 3,
                CreatedAt = seedDate[2],
                Name = "Piotr",
                Surname = "Mazur",
                Email = "piotr.mazur@example.com",
                PhoneNumber = "502300400"
            },
            new Client
            {
                Id = 4,
                CreatedAt = seedDate[3],
                Name = "Karolina",
                Surname = "Dąbrowska",
                Email = "karolina.dabrowska@example.com",
                PhoneNumber = "503400500"
            },
            new Client
            {
                Id = 5,
                CreatedAt = seedDate[4],
                Name = "Michał",
                Surname = "Piotrowski",
                Email = "michal.piotrowski@example.com",
                PhoneNumber = "504500600"
            },
            new Client
            {
                Id = 6,
                CreatedAt = seedDate[5],
                Name = "Natalia",
                Surname = "Grabowska",
                Email = "natalia.grabowska@example.com",
                PhoneNumber = "505600700"
            },
            new Client
            {
                Id = 7,
                CreatedAt = seedDate[6],
                Name = "Krzysztof",
                Surname = "Pawlak",
                Email = "krzysztof.pawlak@example.com",
                PhoneNumber = "506700800"
            },
            new Client
            {
                Id = 8,
                CreatedAt = seedDate[7],
                Name = "Magdalena",
                Surname = "Michalska",
                Email = "magdalena.michalska@example.com",
                PhoneNumber = "507800900"
            },
            new Client
            {
                Id = 9,
                CreatedAt = seedDate[8],
                Name = "Paweł",
                Surname = "Król",
                Email = "pawel.krol@example.com",
                PhoneNumber = "508900100"
            },
            new Client
            {
                Id = 10,
                CreatedAt = seedDate[9],
                Name = "Agnieszka",
                Surname = "Wieczorek",
                Email = "agnieszka.wieczorek@example.com",
                PhoneNumber = "509100200"
            }
        );
    }
}
