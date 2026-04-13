using LibraryBlazorApp.Application.Interfaces;
using LibraryBlazorApp.Domain.Models;
using LibraryBlazorApp.Domain.Models.Results;
using LibraryBlazorApp.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace LibraryBlazorApp.Infrastructure.Repositories.Querie;

public class BookQuery : IBookQuery
{
    private readonly IDbContextFactory<BlazorLibraryDbContext> _contextFactory;
    public BookQuery(IDbContextFactory<BlazorLibraryDbContext> contextFactory)
    {
        _contextFactory = contextFactory;
    }

    public async Task<Result<List<Book>>> GetBooksAndAuthorsAsync()
    {
        await using var dbContext = await _contextFactory.CreateDbContextAsync();

        var booksDb = await dbContext.Books
            .Include(b => b.Author).OrderBy(b => b.Author.Surname)
            .ToListAsync();

        if (!booksDb.Any()) return Errors.BookNotFound;

        return booksDb;
    }
    public async Task<Result<Book>> GetBookByIdAsync(int Id)
    {
        await using var dbContext = await _contextFactory.CreateDbContextAsync();
        var bookDb = await dbContext.Books
            .Include(b => b.Author)
            .FirstOrDefaultAsync(b => b.Id == Id);

        if (bookDb is null) return Errors.BookNotFound;

        return bookDb;
    }


}
