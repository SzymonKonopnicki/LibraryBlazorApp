using LibraryBlazorApp.Application.Dto;
using LibraryBlazorApp.Domain.Models;

namespace LibraryBlazorApp.Application.Services.Maps;

public static class AuthorMaper
{
    public static AuthorDto ToAuthorDto(Author author)
    {
        return new AuthorDto()
        {
            Id = author.Id,
            Name = author.Name,
            Surname = author.Surname
        };
    }
    public static List<AuthorDto> ToAuthorDto(List<Author> authors)
    {
        return authors.Select(a => new AuthorDto()
        {
            Id = a.Id,
            Name = a.Name,
            Surname = a.Surname,
        }).ToList();
    }
    public static List<AuthorAdminDto> ToAuthorAdminDto(List<Author> authors)
    {
        return authors.Select(a => new AuthorAdminDto()
        {
            Id = a.Id,
            Name = a.Name,
            Surname = a.Surname,
            IsStillAlive = a.IsStillAlive(),
            Bio = a.Bio ?? "",
            BirthDate = a.BirthDate,
            DeathDate = a.DeathDate,
            Nationality = a.Nationality ?? "",
            CreatedAt = a.CreatedAt,
            UpdatedAt = a.UpdatedAt,
            AuthorBooksCount = a.QuantityOfWrittenBooks()
        }).ToList();
    }
    public static AuthorAdminDto ToAuthorAdminDto(Author author)
    {
        return new AuthorAdminDto()
        {
            Id = author.Id,
            Name = author.Name,
            Surname = author.Surname,
            IsStillAlive = author.IsStillAlive(),
            Bio = author.Bio ?? "",
            BirthDate = author.BirthDate,
            DeathDate = author.DeathDate,
            Nationality = author.Nationality ?? "",
            CreatedAt = author.CreatedAt,
            UpdatedAt = author.UpdatedAt,
            AuthorBooksCount = author.QuantityOfWrittenBooks()
        };
    }
    public static Author ToAuthor(AuthorAddDto author)
    {
        return new Author()
        {
            CreatedAt = DateTime.UtcNow,
            UpdatedAt = DateTime.UtcNow,
            Name = author.Name,
            Surname = author.Surname,
            Bio = author.Bio ?? "",
            BirthDate = author.BirthDate,
            DeathDate = author.DeathDate,
            Nationality = author.Nationality ?? ""
        };
    }

}
