using LibraryBlazorApp.Domain.Interfaces;
using LibraryBlazorApp.Domain.Models;
using LibraryBlazorApp.Domain.Models.Results;

namespace LibraryBlazorApp.Domain.Policies;

public class BookPolicy : IBookPolicy
{
    public Result<IEnumerable<Book>> HasAnyBooks(IEnumerable<Book> books)
    {
        var available = books.Where(b => b.Quantity > 0).ToList();
        if (!available.Any())
            return Errors.NoBooksAvailable;

        return (Result<IEnumerable<Book>>)available;
    }
}
