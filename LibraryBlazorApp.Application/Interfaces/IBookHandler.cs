using LibraryBlazorApp.Application.Dto;
using LibraryBlazorApp.Domain.Models.Results;

namespace LibraryBlazorApp.Application.Interfaces;

public interface IBookHandler
{
    public Task<Result<List<BookDto>>> GetAvailableBooksAsync();
}
