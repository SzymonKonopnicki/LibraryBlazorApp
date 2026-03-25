using LibraryBlazorApp.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace LibraryBlazorApp.Infrastructure.Data.Configurations.DataSeed;

public static class LoanSeedExtension
{
    public static void SeedLoans(this ModelBuilder modelBuilder)
    {
        var seedDate = new[]
        {
            new DateTime(2024, 3, 1, 0, 0, 0, DateTimeKind.Utc),
            new DateTime(2024, 3, 5, 0, 0, 0, DateTimeKind.Utc),
            new DateTime(2024, 3, 8, 0, 0, 0, DateTimeKind.Utc),
            new DateTime(2024, 3, 10, 0, 0, 0, DateTimeKind.Utc),
            new DateTime(2024, 3, 12, 0, 0, 0, DateTimeKind.Utc),
            new DateTime(2024, 3, 15, 0, 0, 0, DateTimeKind.Utc),
            new DateTime(2024, 3, 18, 0, 0, 0, DateTimeKind.Utc),
            new DateTime(2024, 3, 20, 0, 0, 0, DateTimeKind.Utc),
            new DateTime(2024, 3, 22, 0, 0, 0, DateTimeKind.Utc),
            new DateTime(2024, 3, 25, 0, 0, 0, DateTimeKind.Utc),
            new DateTime(2024, 3, 27, 0, 0, 0, DateTimeKind.Utc),
            new DateTime(2024, 3, 28, 0, 0, 0, DateTimeKind.Utc),
            new DateTime(2024, 3, 29, 0, 0, 0, DateTimeKind.Utc),
            new DateTime(2024, 3, 30, 0, 0, 0, DateTimeKind.Utc),
            new DateTime(2024, 4, 1, 0, 0, 0, DateTimeKind.Utc),
            new DateTime(2024, 4, 2, 0, 0, 0, DateTimeKind.Utc),
            new DateTime(2024, 4, 4, 0, 0, 0, DateTimeKind.Utc),
            new DateTime(2024, 4, 5, 0, 0, 0, DateTimeKind.Utc),
            new DateTime(2024, 4, 7, 0, 0, 0, DateTimeKind.Utc),
            new DateTime(2024, 4, 8, 0, 0, 0, DateTimeKind.Utc),
            new DateTime(2024, 4, 10, 0, 0, 0, DateTimeKind.Utc),
            new DateTime(2024, 4, 12, 0, 0, 0, DateTimeKind.Utc),
            new DateTime(2024, 4, 14, 0, 0, 0, DateTimeKind.Utc),
            new DateTime(2024, 4, 15, 0, 0, 0, DateTimeKind.Utc)
        };

        modelBuilder.Entity<Loan>().HasData(
            new Loan { Id = 1, LibraryCardId = 1, BookId = 1, BorrowDate = seedDate[0], ReturnedDate = null },
            new Loan { Id = 2, LibraryCardId = 1, BookId = 2, BorrowDate = seedDate[1], ReturnedDate = seedDate[5] },
            new Loan { Id = 3, LibraryCardId = 2, BookId = 3, BorrowDate = seedDate[2], ReturnedDate = seedDate[6] },
            new Loan { Id = 4, LibraryCardId = 3, BookId = 4, BorrowDate = seedDate[3], ReturnedDate = null },
            new Loan { Id = 5, LibraryCardId = 3, BookId = 5, BorrowDate = seedDate[4], ReturnedDate = null },
            new Loan { Id = 6, LibraryCardId = 3, BookId = 6, BorrowDate = seedDate[5], ReturnedDate = seedDate[10] },
            new Loan { Id = 7, LibraryCardId = 4, BookId = 7, BorrowDate = seedDate[6], ReturnedDate = seedDate[11] },
            new Loan { Id = 8, LibraryCardId = 5, BookId = 8, BorrowDate = seedDate[7], ReturnedDate = null },
            new Loan { Id = 9, LibraryCardId = 5, BookId = 9, BorrowDate = seedDate[8], ReturnedDate = null },
            new Loan { Id = 10, LibraryCardId = 5, BookId = 10, BorrowDate = seedDate[9], ReturnedDate = seedDate[12] },
            new Loan { Id = 11, LibraryCardId = 5, BookId = 11, BorrowDate = seedDate[10], ReturnedDate = seedDate[13] },
            new Loan { Id = 12, LibraryCardId = 6, BookId = 12, BorrowDate = seedDate[11], ReturnedDate = seedDate[14] },
            new Loan { Id = 13, LibraryCardId = 6, BookId = 13, BorrowDate = seedDate[12], ReturnedDate = seedDate[15] },
            new Loan { Id = 14, LibraryCardId = 7, BookId = 14, BorrowDate = seedDate[13], ReturnedDate = null },
            new Loan { Id = 15, LibraryCardId = 7, BookId = 15, BorrowDate = seedDate[14], ReturnedDate = null },
            new Loan { Id = 16, LibraryCardId = 7, BookId = 16, BorrowDate = seedDate[15], ReturnedDate = seedDate[16] },
            new Loan { Id = 17, LibraryCardId = 8, BookId = 17, BorrowDate = seedDate[16], ReturnedDate = seedDate[17] },
            new Loan { Id = 18, LibraryCardId = 9, BookId = 18, BorrowDate = seedDate[17], ReturnedDate = null },
            new Loan { Id = 19, LibraryCardId = 9, BookId = 19, BorrowDate = seedDate[18], ReturnedDate = null },
            new Loan { Id = 20, LibraryCardId = 9, BookId = 20, BorrowDate = seedDate[19], ReturnedDate = null },
            new Loan { Id = 21, LibraryCardId = 9, BookId = 1, BorrowDate = seedDate[20], ReturnedDate = seedDate[21] },
            new Loan { Id = 22, LibraryCardId = 9, BookId = 2, BorrowDate = seedDate[21], ReturnedDate = seedDate[22] },
            new Loan { Id = 23, LibraryCardId = 10, BookId = 3, BorrowDate = seedDate[22], ReturnedDate = seedDate[23] },
            new Loan { Id = 24, LibraryCardId = 10, BookId = 4, BorrowDate = seedDate[23], ReturnedDate = seedDate[0] }
        );
    }
}
