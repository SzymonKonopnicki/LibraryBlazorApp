using LibraryBlazorApp.Domain.Models;
using LibraryBlazorApp.Domain.Models.Results;

namespace LibraryBlazorApp.Domain.Interfaces;

public interface IBookPolicy
{
    public Result<IEnumerable<Book>> HasAnyBooks(IEnumerable<Book> books);
}
