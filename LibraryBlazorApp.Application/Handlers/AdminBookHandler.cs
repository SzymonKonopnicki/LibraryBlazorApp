using LibraryBlazorApp.Application.Dto;
using LibraryBlazorApp.Application.Interfaces;
using LibraryBlazorApp.Application.Services.Maps;
using LibraryBlazorApp.Domain.Interfaces;
using LibraryBlazorApp.Domain.Models;
using LibraryBlazorApp.Domain.Models.Results;

namespace LibraryBlazorApp.Application.Handlers;

public class AdminBookHandler : IAdminBookHandler
{
    private readonly IBookQuery _bookQuery;
    private readonly IBookAdminCommand _bookAdminCommand;
    private readonly IBookPolicy _bookPolicy;
    public AdminBookHandler(IBookQuery bookQuery, IBookAdminCommand bookAdminCommand, IBookPolicy bookPolicy)
    {
        _bookAdminCommand = bookAdminCommand;
        _bookQuery = bookQuery;
        _bookPolicy = bookPolicy;
    }

    public async Task<Result<List<BookAdminDto>>> GetBooksAsync()
    {
        var dbBooksResult = await _bookQuery.GetBooksAndAuthorsAsync();
        if (!dbBooksResult.IsSuccess) return dbBooksResult.Error!;
        Result<IEnumerable<Book>> result = _bookPolicy.HasZeroOrMoreBooks(dbBooksResult.Value);
        if (!result.IsSuccess) return result.Error!;
        var booksDto = BookMaper.ToAdminDto(result.Value);
        return booksDto.ToList();
    }
    public async Task<Result<List<LoanBookDto>>> GetBooksForLoanAsync()
    {
        var dbBooksResult = await _bookQuery.GetBooksAndAuthorsAsync();
        if (!dbBooksResult.IsSuccess) return dbBooksResult.Error!;
        Result<IEnumerable<Book>> result = _bookPolicy.HasOneOrMoreBooks(dbBooksResult.Value);
        if (!result.IsSuccess) return result.Error!;
        var booksDto = BookMaper.ToLoanBookDto(result.Value);
        return booksDto.ToList();
    }
    public async Task<Result<BookAdminDto>> EditBookAsync(int bookId, BookEditDto editDto)
    {
        var mapBook = BookMaper.ToBook(editDto);
        var result = await _bookAdminCommand.UpdateBookAsync(bookId, mapBook);
        if (!result.IsSuccess) return result.Error!;
        var booksDto = BookMaper.ToAdminDto(result.Value);
        return booksDto;
    }
    public async Task<Result<BookAdminDto>> AddBookAsync(BookAddDto addDto)
    {
        var mapBook = BookMaper.ToBook(addDto);
        var result = await _bookAdminCommand.AddBookAsync(mapBook);
        if (!result.IsSuccess) return result.Error!;
        var booksDto = BookMaper.ToAdminDto(result.Value);
        return booksDto;
    }
    public async Task<Result<int>> DeleteBooksAsync(List<int> booksId)
    {
        var commandResult = await _bookAdminCommand.DeleteBooksAsync(booksId);
        if (!commandResult.IsSuccess) return commandResult.Error!;
        return commandResult;
    }
}
