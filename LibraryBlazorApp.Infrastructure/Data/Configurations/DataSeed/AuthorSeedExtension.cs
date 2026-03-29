using LibraryBlazorApp.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace LibraryBlazorApp.Infrastructure.Data.Configurations.DataSeed;

public static class AuthorSeedExtension
{
    public static void SeedAuthors(this ModelBuilder modelBuilder)
    {
        var seedDate = new[]
        {
            new DateTime(2022, 2, 28, 0, 0, 0, DateTimeKind.Utc),
            new DateTime(2024, 3, 15, 0, 0, 0, DateTimeKind.Utc),
            new DateTime(2020, 9, 3, 0, 0, 0, DateTimeKind.Utc),
            new DateTime(2023, 7, 22, 0, 0, 0, DateTimeKind.Utc),
            new DateTime(2021, 4, 19, 0, 0, 0, DateTimeKind.Utc),
            new DateTime(2022, 11, 5, 0, 0, 0, DateTimeKind.Utc)
        };

        modelBuilder.Entity<Author>().HasData
        (
            new Author
            {
                Id = 1,
                CreatedAt = seedDate[0],
                UpdatedAt = seedDate[0],
                Name = "Jan",
                Surname = "Kowalski",
                Bio = "Polski pisarz specjalizujący się w literaturze kryminalnej i thrillerach psychologicznych.",
                BirthDate = new DateTime(1980, 5, 12),
                Nationality = "Polska"
            },
            new Author
            {
                Id = 2,
                CreatedAt = seedDate[1],
                UpdatedAt = seedDate[1],
                Name = "Anna",
                Surname = "Nowak",
                Bio = "Autorka bestsellerowych powieści obyczajowych i romansów.",
                BirthDate = new DateTime(1975, 3, 22),
                Nationality = "Polska"
            },
            new Author
            {
                Id = 3,
                CreatedAt = seedDate[2],
                UpdatedAt = seedDate[2],
                Name = "Marek",
                Surname = "Zieliński",
                Bio = "Twórca epickich powieści fantasy inspirowanych mitologią słowiańską.",
                BirthDate = new DateTime(1990, 11, 3),
                Nationality = "Polska"
            },
            new Author
            {
                Id = 4,
                CreatedAt = seedDate[3],
                UpdatedAt = seedDate[3],
                Name = "Katarzyna",
                Surname = "Wiśniewska",
                Bio = "Pisarka science fiction, koncentrująca się na sztucznej inteligencji i przyszłości technologii.",
                BirthDate = new DateTime(1985, 7, 18),
                Nationality = "Polska"
            },
            new Author
            {
                Id = 5,
                CreatedAt = seedDate[4],
                UpdatedAt = seedDate[4],
                Name = "Tomasz",
                Surname = "Lewandowski",
                Bio = "Autor książek popularnonaukowych z zakresu psychologii i rozwoju osobistego.",
                BirthDate = new DateTime(1978, 1, 9),
                Nationality = "Polska"
            },
            new Author
            {
                Id = 6,
                CreatedAt = seedDate[5],
                UpdatedAt = seedDate[5],
                Name = "Anonim",
                Surname = "",
                Bio = "Autor pozostający w ukryciu. Tożsamość nieznana, brak potwierdzonych informacji biograficznych.",
                BirthDate = null,
                DeathDate = null,
                Nationality = "Nieznana"
            }
        );
    }
}
