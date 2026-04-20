using LibraryBlazorApp.Domain.Models;
using LibraryBlazorApp.Domain.Models.Results;

namespace LibraryBlazorApp.Application.Interfaces;

public interface ILibraryCardQuery
{
    public Task<Result<LibraryCard>> GetLibraryCardAsync(string UserId);
}
