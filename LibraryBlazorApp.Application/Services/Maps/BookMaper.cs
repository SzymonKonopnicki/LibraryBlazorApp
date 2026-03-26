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
}
