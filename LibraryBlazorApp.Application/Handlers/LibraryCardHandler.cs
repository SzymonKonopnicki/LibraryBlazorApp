using LibraryBlazorApp.Application.Dto.LibraryCard;
using LibraryBlazorApp.Application.Interfaces;
using LibraryBlazorApp.Application.Services.Maps;
using LibraryBlazorApp.Domain.Models.Results;

namespace LibraryBlazorApp.Application.Handlers;

public class LibraryCardHandler : ILibraryCardHandler
{
    private readonly ILibraryCardQuery _cardQuery;
    public LibraryCardHandler(ILibraryCardQuery cardQuery)
    {
        _cardQuery = cardQuery;
    }
    public async Task<Result<LibraryCardDto>> GetLibraryCardDtoAsync(string userId)
    {
        var queryResult = await _cardQuery.GetLibraryCardAsync(userId);
        if (!queryResult.IsSuccess) return queryResult.Error!;
        var cardMap = CardMaper.ToLibraryCardDto(queryResult.Value);
        return cardMap;
    }
}
