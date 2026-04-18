using LibraryBlazorApp.Domain.Models;
using LibraryBlazorApp.Domain.Models.Results;

namespace LibraryBlazorApp.Application.Interfaces.Admin;

public interface IAdminBookCommand
{
    public Task<Result<Book>> AddBookAsync(Book book);
    public Task<Result<Book>> UpdateBookAsync(int bookId, Book book);
    public Task<Result<int>> DeleteBooksAsync(List<int> booksId);
    public Task<Result> IncreaseBookQuantityAsync(int bookId, int add);
    public Task<Result> DecreaseBookQuantityAsync(int bookId, int subtract);
}
