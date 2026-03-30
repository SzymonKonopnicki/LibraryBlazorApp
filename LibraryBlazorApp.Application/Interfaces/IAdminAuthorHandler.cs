using LibraryBlazorApp.Application.Dto;
using LibraryBlazorApp.Domain.Models.Results;

namespace LibraryBlazorApp.Application.Interfaces;

public interface IAdminAuthorHandler
{
    public Task<Result<List<AuthorDto>>> GetAuthorsAsync();
    public Task<Result<List<AuthorAdminDto>>> GeAuthorAdminDtosAsync();
    public Task<Result<AuthorAdminDto>> AddAuthorAddDtoAsync(AuthorAddDto addDto);
    public Task<Result<int>> DeleteBooksByIdsAsync(List<int> ids);
    public Task<Result<AuthorAdminDto>> EditAuthorAsync(int authorId, AuthorEditAdminDto authorEdit);

}
