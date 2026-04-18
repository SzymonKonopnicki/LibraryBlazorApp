using LibraryBlazorApp.Application.Dto;
using LibraryBlazorApp.Domain.Models.Results;

namespace LibraryBlazorApp.Application.Interfaces.Admin;

public interface IAdminClientHandler
{
    public Task<Result<List<ClientAdminDto>>> GetAdminClientAsync();
    public Task<Result<int>> DeleteAdminBooksByIdsAsync(List<int> clientIds);
    public Task<Result<ClientAdminDto>> EditAdminAuthorAsync(int clientId, ClientEditAdminDto clientEdit);
    public Task<Result<ClientAdminDto>> AddAdminClientDtoAsync(ClientAddAdminDto clientAdd);

}
