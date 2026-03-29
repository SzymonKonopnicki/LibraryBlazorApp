using LibraryBlazorApp.Application.Dto;
using LibraryBlazorApp.Domain.Models.Results;

namespace LibraryBlazorApp.Application.Interfaces;

public interface IAdminBookHandler
{
    public Task<Result<List<BookAdminDto>>> GetBooksAsync();
    public Task<Result<BookAdminDto>> EditBookAsync(int bookId, BookEditDto editDto);

}
