using LibraryBlazorApp.Application.Dto;
using LibraryBlazorApp.Domain.Models;
using LibraryBlazorApp.Domain.Models.Results;

namespace LibraryBlazorApp.Application.Interfaces;

public interface IBookAdminCommand
{
    public Task<Result<Book>> AddBookAsync(Book book);
    public Task<Result<Book>> UpdateBookAsync(int bookId, Book book);
}
