using LibraryBlazorApp.Application.Interfaces;
using LibraryBlazorApp.Domain.Models;
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

    public async Task<List<Book>> GetBooksAndAuthorsAsync()
    {
        await using var dbContext = await _contextFactory.CreateDbContextAsync();

        return await dbContext.Books
            .Include(b => b.Author)
            .ToListAsync();
    }
}
