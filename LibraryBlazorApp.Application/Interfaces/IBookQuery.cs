using LibraryBlazorApp.Domain.Models;

namespace LibraryBlazorApp.Application.Interfaces;

public interface IBookQuery
{
    public Task<List<Book>> GetBooksAndAuthorsAsync();
}
