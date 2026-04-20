using LibraryBlazorApp.Application.Dto.LibraryCard;
using LibraryBlazorApp.Domain.Models.Results;

namespace LibraryBlazorApp.Application.Interfaces;

public interface ILibraryCardHandler
{
    public Task<Result<LibraryCardDto>> GetLibraryCardDtoAsync(string userId);
}
