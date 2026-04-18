using LibraryBlazorApp.Application.Dto;
using LibraryBlazorApp.Domain.Models;

namespace LibraryBlazorApp.Application.Services.Maps;

public static class CardMaper
{
    public static List<LibraryCardAdminDto> ToLibraryCardAdminDto(List<LibraryCard> cards)
    {
        return cards.Select(c => new LibraryCardAdminDto()
        {
            Id = c.Id,
            CreatedAt = c.CreatedAt,
            Loans = c.Loans.Select(l => new LoanAdminDto()
            {
                Id = l.Id,
                BookId = l.BookId,
                BookTitle = l.Book.Title,
                ReturnedStatus = l.ReturnedStatus(),
                PenaltyForDetention = l.PenaltyForDetention(),
                BorrowDate = l.BorrowDate,
                ReturnedDate = l.ReturnedDate ?? null,
            }).ToList(),
            ClientId = c.Client.Id,
            ClienName = c.Client.Name,
            ClienSurname = c.Client.Surname,
            CanBorrowBook = c.CanBorrowBook(),
            PenaltyForBorrow = c.PenaltyForBorrow(),
            QuantityOfBorrowedBook = c.QuantityOfBorrowedBook()

        }).ToList();
    }
    public static LibraryCardAdminDto ToLibraryCardAdminDto(LibraryCard card)
    {
        return new LibraryCardAdminDto()
        {
            Id = card.Id,
            CreatedAt = card.CreatedAt,
            Loans = card.Loans.Select(l => new LoanAdminDto()
            {
                Id = l.Id,
                BookId = l.BookId,
                BookTitle = l.Book.Title,
                ReturnedStatus = l.ReturnedStatus(),
                PenaltyForDetention = l.PenaltyForDetention(),
                BorrowDate = l.BorrowDate,
                ReturnedDate = l.ReturnedDate ?? null,
            }).ToList(),
            ClientId = card.Client.Id,
            ClienName = card.Client.Name,
            ClienSurname = card.Client.Surname,
            CanBorrowBook = card.CanBorrowBook(),
            PenaltyForBorrow = card.PenaltyForBorrow(),
            QuantityOfBorrowedBook = card.QuantityOfBorrowedBook()
        };
    }

}
