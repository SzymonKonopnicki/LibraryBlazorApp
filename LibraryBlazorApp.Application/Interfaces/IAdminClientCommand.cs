using LibraryBlazorApp.Domain.Models;
using LibraryBlazorApp.Domain.Models.Results;

namespace LibraryBlazorApp.Application.Interfaces;

public interface IAdminClientCommand
{
    public Task<Result<int>> DeleteAdminClientByIdsAsync(List<int> ids);
    public Task<Result<Client>> AddAdminClientAsync(Client client);
    public Task<Result<Client>> EditAdminClientAsync(int clientId, Client clientMap);
}
