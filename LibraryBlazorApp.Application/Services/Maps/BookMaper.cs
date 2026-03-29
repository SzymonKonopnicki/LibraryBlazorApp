using LibraryBlazorApp.Application.Dto;
using LibraryBlazorApp.Domain.Models;

namespace LibraryBlazorApp.Application.Services.Maps;

public static class BookMaper
{
    public static IEnumerable<BookDto> ToDto(IEnumerable<Book> books)
    {
        return books.Select(b => new BookDto
        {
            Title = b.Title,
            Description = b.Description,
            Quantity = b.Quantity,
            AuthorName = b.Author.Name,
            AuthorSurname = b.Author.Surname,
            Bio = b.Author.Bio,
            BirthDate = b.Author.BirthDate,
            DeathDate = b.Author.DeathDate,
        }).ToList();
    }
    public static IEnumerable<BookAdminDto> ToAdminDto(IEnumerable<Book> books)
    {
        return books.Select(b => new BookAdminDto
        {
            Id = b.Id,
            BookCreatedAt = b.CreatedAt,
            BookUpdatedAt = b.UpdatedAt,
            BookStatus = b.GetAvailabilityStatus(),
            Title = b.Title,
            Description = b.Description,
            Quantity = b.Quantity,
            AuthorId = b.Author.Id,
            AuthorCreatedAt = b.Author.CreatedAt,
            AuthorName = b.Author.Name,
            AuthorSurname = b.Author.Surname,
            Bio = b.Author.Bio,
            BirthDate = b.Author.BirthDate,
            DeathDate = b.Author.DeathDate,
            AuthorNationality = b.Author.Nationality,
            IsAuthorAlive = b.Author.IsStillAlive()
        }).ToList();
    }
    public static BookAdminDto ToAdminDto(Book book)
    {
        return new BookAdminDto()
        {
            Id = book.Id,
            BookCreatedAt = book.CreatedAt,
            BookUpdatedAt = book.UpdatedAt,
            BookStatus = book.GetAvailabilityStatus(),
            Title = book.Title,
            Description = book.Description,
            Quantity = book.Quantity,
            AuthorId = book.Author.Id,
            AuthorCreatedAt = book.Author.CreatedAt,
            AuthorName = book.Author.Name,
            AuthorSurname = book.Author.Surname,
            Bio = book.Author.Bio,
            BirthDate = book.Author.BirthDate,
            DeathDate = book.Author.DeathDate,
            AuthorNationality = book.Author.Nationality,
            IsAuthorAlive = book.Author.IsStillAlive()
        };
    }
    public static Book ToBook(BookEditDto book)
    {
        return new Book()
        {
            Title = book.Title,
            Description = book.Description,
            Quantity = book.Quantity
        };
    }
    public static Book ToBook(BookAddDto book)
    {
        return new Book()
        {
            Title = book.Title,
            Description = book.Description,
            Quantity = book.Quantity,
            AuthorId = book.AuthorId
        };
    }

}
