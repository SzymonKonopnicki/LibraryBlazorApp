using LibraryBlazorApp.Application.Dto;
using LibraryBlazorApp.Application.Interfaces;
using LibraryBlazorApp.Application.Services.Maps;
using LibraryBlazorApp.Domain.Models.Results;

namespace LibraryBlazorApp.Application.Handlers;

public class AdminAuthorHandler : IAdminAuthorHandler
{
    private readonly IAuthorAdminQuery _adminQuery;
    public AdminAuthorHandler(IAuthorAdminQuery adminQuery)
    {
        _adminQuery = adminQuery;
    }

    public async Task<Result<List<AuthorDto>>> GetAuthorsAsync()
    {
        var result = await _adminQuery.GetAuthorsAsync();
        if (!result.IsSuccess) return result.Error!;
        var authorMap = AuthorMaper.ToAuthorDto(result.Value);
        return authorMap;
    }

    public async Task<Result<List<AuthorAdminDto>>> GeAuthorAdminDtosAsync()
    {
        var queryResult = await _adminQuery.GetAuthorsWithBooksAsync();
        if (!queryResult.IsSuccess) return queryResult.Error!;
        var authorsMap = AuthorMaper.ToAuthorAdminDto(queryResult.Value);
        return authorsMap;
    }

}
