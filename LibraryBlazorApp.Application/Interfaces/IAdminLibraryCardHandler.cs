using LibraryBlazorApp.Application.Dto;
using LibraryBlazorApp.Domain.Models.Results;

namespace LibraryBlazorApp.Application.Interfaces;

public interface IAdminLibraryCardHandler
{
    public Task<Result<List<LibraryCardAdminDto>>> GetLibraryCardAdminDtoAsync();
    public Task<Result<int>> DeleteLibraryCardByIdsAsync(List<int> ids);
    public Task<Result<LibraryCardAdminDto>> AddLibraryCardDtoAsync(ClientAddAdminDto clientAdd);
}
