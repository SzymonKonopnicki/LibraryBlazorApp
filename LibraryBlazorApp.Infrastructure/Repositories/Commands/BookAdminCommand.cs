using Azure.Core;
using LibraryBlazorApp.Application.Interfaces;
using LibraryBlazorApp.Domain.Models;
using LibraryBlazorApp.Domain.Models.Results;
using LibraryBlazorApp.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace LibraryBlazorApp.Infrastructure.Repositories.Commands;

public class BookAdminCommand : IBookAdminCommand
{
    private readonly IDbContextFactory<BlazorLibraryDbContext> _contextFactory;
    public BookAdminCommand(IDbContextFactory<BlazorLibraryDbContext> contextFactory)
    {
        _contextFactory = contextFactory;
    }

    public async Task<Result<Book>> AddBookAsync(Book book)
    {
        using var dbContext = await _contextFactory.CreateDbContextAsync();
        await dbContext.AddAsync(book);
        await dbContext.SaveChangesAsync();

        return await dbContext.Books.Include(a => a.Author).FirstOrDefaultAsync(b => b.Id == book.Id);
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
    public async Task<Result<int>> DeleteBooksAsync(List<int> booksId)
    {
        using var dbContext = await _contextFactory.CreateDbContextAsync();
        var toRemove = await dbContext.Books.Where(b => booksId.Contains(b.Id)).ToListAsync();
        if (!toRemove.Any()) return Errors.BookNotFound;
        dbContext.Books.RemoveRange(toRemove);
        await dbContext.SaveChangesAsync();
        return toRemove.Count;
    }
}
