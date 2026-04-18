using LibraryBlazorApp.Domain.Models;
using LibraryBlazorApp.Domain.Models.Results;

namespace LibraryBlazorApp.Application.Interfaces.Admin;

public interface IAuthorAdminQuery
{
    public Task<Result<List<Author>>> GetAuthorsAsync();
    public Task<Result<List<Author>>> GetAuthorsWithBooksAsync();
}
