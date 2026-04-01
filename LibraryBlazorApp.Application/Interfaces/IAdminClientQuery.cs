using LibraryBlazorApp.Domain.Models;
using LibraryBlazorApp.Domain.Models.Results;

namespace LibraryBlazorApp.Application.Interfaces;

public interface IAdminClientQuery
{
    public Task<Result<List<Client>>> GetClientsAsync();
}
