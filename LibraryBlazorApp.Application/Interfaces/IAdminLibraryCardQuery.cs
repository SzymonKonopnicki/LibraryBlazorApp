using LibraryBlazorApp.Domain.Models;
using LibraryBlazorApp.Domain.Models.Results;

namespace LibraryBlazorApp.Application.Interfaces;

public interface IAdminLibraryCardQuery
{
    public Task<Result<List<LibraryCard>>> GetLibraryCardAsync();
    public Task<Result<LibraryCard>> GetLibraryCardAsync(int cardId);
}
