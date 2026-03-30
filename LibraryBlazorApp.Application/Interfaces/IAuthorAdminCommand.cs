using LibraryBlazorApp.Domain.Models;
using LibraryBlazorApp.Domain.Models.Results;

namespace LibraryBlazorApp.Application.Interfaces;

public interface IAuthorAdminCommand
{
    public Task<Result<Author>> AddAuthorAsync(Author author);
    public Task<Result<int>> DeleteAuthorAsync(List<int> ids);
    public Task<Result<Author>> EditAuthorAsync(int authorId, Author mapAuthor);
}
