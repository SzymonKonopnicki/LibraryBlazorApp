using LibraryBlazorApp.Domain.Models;
using LibraryBlazorApp.Domain.Models.Results;

namespace LibraryBlazorApp.Application.Interfaces;

public interface IBookAdminCommand
{
    public Task<Result<Book>> UpdateBookAsync(int bookId, Book book);
}
