using LibraryBlazorApp.Domain.Models;
using LibraryBlazorApp.Domain.Models.Results;

namespace LibraryBlazorApp.Application.Interfaces;

public interface IBookQuery
{
    public Task<Result<List<Book>>> GetBooksAndAuthorsAsync();
    public Task<Result<Book>> GetBookByIdAsync(int Id);
}
