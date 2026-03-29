using LibraryBlazorApp.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace LibraryBlazorApp.Infrastructure.Data.Configurations.DataSeed;

public static class BookSeedExtension
{
    public static void SeedBooks(this ModelBuilder modelBuilder)
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
            new DateTime(2020, 8, 17, 0, 0, 0, DateTimeKind.Utc),
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

        modelBuilder.Entity<Book>().HasData(
            new Book { Id = 1, CreatedAt = seedDate[0], UpdatedAt = seedDate[0], Title = "Cień Wiatru", Description = "Tajemnicza historia książki i jej autora", Quantity = 5, AuthorId = 1 },
            new Book { Id = 2, CreatedAt = seedDate[1], UpdatedAt = seedDate[1], Title = "Kod Przeznaczenia", Description = "Thriller technologiczny o sztucznej inteligencji", Quantity = 3, AuthorId = 2 },
            new Book { Id = 3, CreatedAt = seedDate[2], UpdatedAt = seedDate[2], Title = "Ostatni Strażnik", Description = "Fantastyczna opowieść o upadłym królestwie", Quantity = 7, AuthorId = 3 },
            new Book { Id = 4, CreatedAt = seedDate[3], UpdatedAt = seedDate[3], Title = "Miasto Cieni", Description = "Kryminał noir w futurystycznym świecie", Quantity = 4, AuthorId = 4 },
            new Book { Id = 5, CreatedAt = seedDate[4], UpdatedAt = seedDate[4], Title = "Sekrety Umysłu", Description = "Popularnonaukowa książka o psychologii", Quantity = 6, AuthorId = 5 },
            new Book { Id = 6, CreatedAt = seedDate[5], UpdatedAt = seedDate[5], Title = "Zaginiony Symbol", Description = "Zagadka ukryta w historii", Quantity = 2, AuthorId = 1 },
            new Book { Id = 7, CreatedAt = seedDate[6], UpdatedAt = seedDate[6], Title = "Droga Wojownika", Description = "Filozofia i rozwój osobisty", Quantity = 8, AuthorId = 2 },
            new Book { Id = 8, CreatedAt = seedDate[7], UpdatedAt = seedDate[7], Title = "Echo Przeszłości", Description = "Saga rodzinna na przestrzeni pokoleń", Quantity = 3, AuthorId = 3 },
            new Book { Id = 9, CreatedAt = seedDate[8], UpdatedAt = seedDate[8], Title = "Granice Rzeczywistości", Description = "Sci-fi o podróżach między wymiarami", Quantity = 5, AuthorId = 4 },
            new Book { Id = 10, CreatedAt = seedDate[9], UpdatedAt = seedDate[9], Title = "Czas Milczenia", Description = "Dramat psychologiczny", Quantity = 4, AuthorId = 5 },
            new Book { Id = 11, CreatedAt = seedDate[10], UpdatedAt = seedDate[10], Title = "Złodziej Snów", Description = "Fantastyczna historia o manipulacji snami", Quantity = 6, AuthorId = 1 },
            new Book { Id = 12, CreatedAt = seedDate[11], UpdatedAt = seedDate[11], Title = "Labirynt Prawdy", Description = "Śledztwo pełne zwrotów akcji", Quantity = 2, AuthorId = 2 },
            new Book { Id = 13, CreatedAt = seedDate[12], UpdatedAt = seedDate[12], Title = "Królestwo Popiołów", Description = "Epicka fantasy o walce o tron", Quantity = 9, AuthorId = 3 },
            new Book { Id = 14, CreatedAt = seedDate[13], UpdatedAt = seedDate[13], Title = "Algorytm Chaosu", Description = "Programista odkrywa globalny spisek", Quantity = 3, AuthorId = 4 },
            new Book { Id = 15, CreatedAt = seedDate[14], UpdatedAt = seedDate[14], Title = "Milczący Świadek", Description = "Kryminał sądowy", Quantity = 5, AuthorId = 5 },
            new Book { Id = 16, CreatedAt = seedDate[15], UpdatedAt = seedDate[15], Title = "Podróż bez Powrotu", Description = "Kosmiczna ekspedycja", Quantity = 7, AuthorId = 1 },
            new Book { Id = 17, CreatedAt = seedDate[16], UpdatedAt = seedDate[16], Title = "Tajemnice DNA", Description = "Genetyka i przyszłość ludzkości", Quantity = 4, AuthorId = 1 },
            new Book { Id = 18, CreatedAt = seedDate[17], UpdatedAt = seedDate[17], Title = "Upadek Imperium", Description = "Historia wielkiego państwa", Quantity = 6, AuthorId = 1 },
            new Book { Id = 19, CreatedAt = seedDate[18], UpdatedAt = seedDate[18], Title = "Czarna Lista", Description = "Thriller polityczny", Quantity = 2, AuthorId = 1 },
            new Book { Id = 20, CreatedAt = seedDate[19], UpdatedAt = seedDate[19], Title = "Światło w Ciemności", Description = "Inspirująca opowieść o nadziei", Quantity = 8, AuthorId = 6 }
        );
    }
}
