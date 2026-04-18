using LibraryBlazorApp.Application.Interfaces.Admin;
using LibraryBlazorApp.Domain.Models;
using LibraryBlazorApp.Domain.Models.Results;
using LibraryBlazorApp.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace LibraryBlazorApp.Infrastructure.Repositories.Queries.Admin;

public class AdminLibraryCardQuery : IAdminLibraryCardQuery
{
    private readonly IDbContextFactory<BlazorLibraryDbContext> _dbContextFactory;
    public AdminLibraryCardQuery(IDbContextFactory<BlazorLibraryDbContext> dbContextFactory)
    {
        _dbContextFactory = dbContextFactory;
    }
    public async Task<Result<List<LibraryCard>>> GetLibraryCardAsync()
    {
        using var dbContext = await _dbContextFactory.CreateDbContextAsync();
        var cards = await dbContext.LibraryCards
            .Include(c => c.Loans).ThenInclude(l => l.Book)
            .Include(c => c.Client)
            .ToListAsync();

        if (!cards.Any()) return Errors.NoLibraryCardsAvailable;
        return cards;
    }

    public async Task<Result<LibraryCard>> GetLibraryCardAsync(int cardId)
    {
        using var dbContext = await _dbContextFactory.CreateDbContextAsync();
        var cards = await dbContext.LibraryCards
            .Include(c => c.Loans).ThenInclude(l => l.Book)
            .Include(c => c.Client)
            .FirstOrDefaultAsync(c => c.Id == cardId);

        if (cards == null) return Errors.LibraryCardNotFound;
        return cards;
    }
}
