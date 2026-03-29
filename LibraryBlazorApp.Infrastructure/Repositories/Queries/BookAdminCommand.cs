using LibraryBlazorApp.Application.Interfaces;
using LibraryBlazorApp.Domain.Models;
using LibraryBlazorApp.Domain.Models.Results;
using LibraryBlazorApp.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace LibraryBlazorApp.Infrastructure.Repositories.Queries;

public class BookAdminCommand : IBookAdminCommand
{
    private readonly IDbContextFactory<BlazorLibraryDbContext> _contextFactory;
    public BookAdminCommand(IDbContextFactory<BlazorLibraryDbContext> contextFactory)
    {
        _contextFactory = contextFactory;
    }

    public async Task<Result<Book>> UpdateBookAsync(int bookId, Book book)
    {
        using var dbContext = await _contextFactory.CreateDbContextAsync();

        var bookDb = await dbContext.Books
            .Include(b => b.Author)
            .FirstOrDefaultAsync(b => b.Id == bookId);
        if (bookDb is null) return Errors.BookNotFound;

        bookDb.Title = book.Title;
        bookDb.Description = book.Description;
        bookDb.Quantity = book.Quantity;
        bookDb.UpdatedAt = DateTime.UtcNow;

        dbContext.Update(bookDb);
        await dbContext.SaveChangesAsync();
        return bookDb;
    }
}
