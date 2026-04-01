using LibraryBlazorApp.Application.Interfaces;
using LibraryBlazorApp.Domain.Models;
using LibraryBlazorApp.Domain.Models.Results;
using LibraryBlazorApp.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace LibraryBlazorApp.Infrastructure.Repositories.Queries;

public class AdminClientQuery : IAdminClientQuery
{
    private readonly IDbContextFactory<BlazorLibraryDbContext> _dbContextFactory;
    public AdminClientQuery(IDbContextFactory<BlazorLibraryDbContext> dbContextFactory)
    {
        _dbContextFactory = dbContextFactory;
    }

    public async Task<Result<List<Client>>> GetClientsAsync()
    {
        using var dbContext = await _dbContextFactory.CreateDbContextAsync();
        var clientsDb = await dbContext.Clients.Include(c => c.Address).ToListAsync();
        if (!clientsDb.Any()) return Errors.NoClientsAvailable;
        return clientsDb;
    }
}
