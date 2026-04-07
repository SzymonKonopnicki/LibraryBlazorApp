using LibraryBlazorApp.Application.Dto;
using LibraryBlazorApp.Application.Interfaces;
using LibraryBlazorApp.Application.Services.Maps;
using LibraryBlazorApp.Domain.Models.Results;

namespace LibraryBlazorApp.Application.Handlers;

public class AdminLibraryCardHandler : IAdminLibraryCardHandler
{
    private readonly IAdminLibraryCardQuery _cardQuery;
    private readonly IAdminClientCommand _clientCommand;
    public AdminLibraryCardHandler(IAdminLibraryCardQuery cardQuery, IAdminClientCommand clientCommand)
    {
        _cardQuery = cardQuery;
        _clientCommand = clientCommand;
    }
    public async Task<Result<List<LibraryCardAdminDto>>> GetLibraryCardAdminDtoAsync()
    {
        var queryResult = await _cardQuery.GetLibraryCardAsync();
        if (!queryResult.IsSuccess) return queryResult.Error!;
        var cardMap = CardMaper.ToLibraryCardAdminDto(queryResult.Value);
        return cardMap;
    }

    public async Task<Result<int>> DeleteLibraryCardByIdsAsync(List<int> clientIds)
    {
        var commandResult = await _clientCommand.DeleteAdminClientByIdsAsync(clientIds);
        if (!commandResult.IsSuccess) return commandResult.Error!;
        return commandResult.Value;
    }

    public async Task<Result<LibraryCardAdminDto>> AddLibraryCardDtoAsync(ClientAddAdminDto clientAdd)
    {
        var clientMap = ClientMaper.ToClient(clientAdd);
        var commandResult = await _clientCommand.AddAdminClientAsync(clientMap);
        if (!commandResult.IsSuccess) return commandResult.Error!;
        var cardDtoMap = CardMaper.ToLibraryCardAdminDto(commandResult.Value.LibraryCard);
        return cardDtoMap;
    }
}
