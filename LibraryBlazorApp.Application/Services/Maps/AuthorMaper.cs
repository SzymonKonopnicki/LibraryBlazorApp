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

}
