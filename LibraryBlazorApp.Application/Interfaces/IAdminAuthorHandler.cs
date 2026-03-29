using LibraryBlazorApp.Application.Dto;
using LibraryBlazorApp.Domain.Models.Results;

namespace LibraryBlazorApp.Application.Interfaces;

public interface IAdminAuthorHandler
{
    public Task<Result<List<AuthorDto>>> GetAuthorsAsync();

}
