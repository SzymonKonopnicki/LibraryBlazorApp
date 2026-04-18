using LibraryBlazorApp.Application.Dto;
using LibraryBlazorApp.Application.Interfaces.Admin;
using LibraryBlazorApp.Application.Services.Maps;
using LibraryBlazorApp.Domain.Models.Results;

namespace LibraryBlazorApp.Application.Handlers.Admin;

public class AdminClientHandler : IAdminClientHandler
{
    private readonly IAdminClientQuery _clientQuery;
    private readonly IAdminClientCommand _clientCommand;
    public AdminClientHandler(IAdminClientQuery clientQuery, IAdminClientCommand clientCommand)
    {
        _clientQuery = clientQuery;
        _clientCommand = clientCommand;
    }
    public async Task<Result<List<ClientAdminDto>>> GetAdminClientAsync()
    {
        var queryResulty = await _clientQuery.GetClientsAsync();
        if (!queryResulty.IsSuccess) return queryResulty.Error!;
        var clientMap = ClientMaper.ToClientAdminDto(queryResulty.Value);
        return clientMap;
    }
    public async Task<Result<int>> DeleteAdminBooksByIdsAsync(List<int> clientIds)
    {
        var commandResult = await _clientCommand.DeleteAdminClientByIdsAsync(clientIds);
        if (!commandResult.IsSuccess) return commandResult.Error!;
        return commandResult.Value;
    }
    public async Task<Result<ClientAdminDto>> EditAdminAuthorAsync(int clientId, ClientEditAdminDto clientEdit)
    {
        var clientMap = ClientMaper.ToClient(clientEdit);
        var commandResult = await _clientCommand.EditAdminClientAsync(clientId, clientMap);
        if (!commandResult.IsSuccess) return commandResult.Error!;
        var clientDtoMap = ClientMaper.ToClientAdminDto(commandResult.Value);
        return clientDtoMap;
    }

    public async Task<Result<ClientAdminDto>> AddAdminClientDtoAsync(ClientAddAdminDto clientAdd)
    {
        var clientMap = ClientMaper.ToClient(clientAdd);
        var commandResult = await _clientCommand.AddAdminClientAsync(clientMap);
        if (!commandResult.IsSuccess) return commandResult.Error!;
        var clientDtoMap = ClientMaper.ToClientAdminDto(commandResult.Value);
        return clientDtoMap;
    }
}
