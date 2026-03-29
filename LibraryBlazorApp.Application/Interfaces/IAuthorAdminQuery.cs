using LibraryBlazorApp.Domain.Models;
using LibraryBlazorApp.Domain.Models.Results;

namespace LibraryBlazorApp.Application.Interfaces;

public interface IAuthorAdminQuery
{
    public Task<Result<List<Author>>> GetAuthors();
}
