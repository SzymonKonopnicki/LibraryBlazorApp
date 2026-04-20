using LibraryBlazorApp.Application.Interfaces;
using LibraryBlazorApp.Domain.Models;
using LibraryBlazorApp.Domain.Models.Results;
using LibraryBlazorApp.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;

namespace LibraryBlazorApp.Infrastructure.Repositories.Queries;

public class LibraryCardQuery : ILibraryCardQuery
{
    private readonly IDbContextFactory<BlazorLibraryDbContext> _dbContextFactory;
    public LibraryCardQuery(IDbContextFactory<BlazorLibraryDbContext> dbContextFactory)
    {
        _dbContextFactory = dbContextFactory;
    }

    public async Task<Result<LibraryCard>> GetLibraryCardAsync(string UserId)
    {
        using var dbContext = await _dbContextFactory.CreateDbContextAsync();
        var client = dbContext.Clients.FirstOrDefaultAsync(c => c.IdentityUserId == UserId);
        if (client == null) return Errors.ClientNotFound;
        var card = await dbContext.LibraryCards
            .Include(c => c.Loans)
            .FirstOrDefaultAsync(c => c.Id == client.Id);

        return card;
    }
}
