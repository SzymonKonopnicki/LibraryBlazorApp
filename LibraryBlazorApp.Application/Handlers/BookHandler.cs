using LibraryBlazorApp.Application.Dto;
using LibraryBlazorApp.Application.Interfaces;
using LibraryBlazorApp.Application.Services.Maps;
using LibraryBlazorApp.Domain.Interfaces;
using LibraryBlazorApp.Domain.Models;
using LibraryBlazorApp.Domain.Models.Results;

namespace LibraryBlazorApp.Application.Handlers;

public class BookHandler : IBookHandler
{
    private readonly IBookQuery _bookQuery;
    private readonly IBookPolicy _bookPolicy;
    public BookHandler(IBookQuery bookQuery, IBookPolicy bookPolicy)
    {
        _bookQuery = bookQuery;
        _bookPolicy = bookPolicy;
    }

    public async Task<Result<List<BookDto>>> GetAvailableBooksAsync()
    {
        var dbBooks = await _bookQuery.GetBooksAndAuthorsAsync();
        Result<IEnumerable<Book>> result = _bookPolicy.HasAnyBooks(dbBooks);

        if (!result.IsSuccess) return result.Error!;

        var booksDto = BookMaper.ToDto(result.Value);

        return booksDto.ToList();
    }
}
