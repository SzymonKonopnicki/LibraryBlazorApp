using LibraryBlazorApp.Application.Interfaces;
using LibraryBlazorApp.Domain.Models;
using LibraryBlazorApp.Domain.Models.Results;
using LibraryBlazorApp.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace LibraryBlazorApp.Infrastructure.Repositories.Commands;

public class AdminClientCommand : IAdminClientCommand
{
    private readonly IDbContextFactory<BlazorLibraryDbContext> _dbContextFactory;
    public AdminClientCommand(IDbContextFactory<BlazorLibraryDbContext> dbContextFactory)
    {
        _dbContextFactory = dbContextFactory;
    }

    public async Task<Result<int>> DeleteAdminClientByIdsAsync(List<int> ids)
    {
        using var dbContext = await _dbContextFactory.CreateDbContextAsync();
        var toRemove = await dbContext.Clients.Where(c => ids.Contains(c.Id)).ToListAsync();
        if (!toRemove.Any()) return Errors.NoClientsAvailable;
        dbContext.Clients.RemoveRange(toRemove);
        await dbContext.SaveChangesAsync();
        return toRemove.Count;
    }
    public async Task<Result<Client>> AddAdminClientAsync(Client client)
    {
        using var dbContext = await _dbContextFactory.CreateDbContextAsync();
        await dbContext.Clients.AddAsync(client);
        await dbContext.SaveChangesAsync();
        return client;
    }

    public async Task<Result<Client>> EditAdminClientAsync(int clientId, Client clientMap)
    {
        using var dbContext = await _dbContextFactory.CreateDbContextAsync();
        var toUpdate = await dbContext.Clients.Include(c => c.Address).FirstOrDefaultAsync(c => c.Id == clientId);
        if (toUpdate is null) return Errors.ClientNotFound;

        toUpdate.UpdatedAt = clientMap.UpdatedAt;
        toUpdate.Name = clientMap.Name;
        toUpdate.Surname = clientMap.Surname;
        toUpdate.Email = clientMap.Email;
        toUpdate.PhoneNumber = clientMap.PhoneNumber;
        toUpdate.Address.UpdatedAt = clientMap.Address.UpdatedAt;
        toUpdate.Address.Country = clientMap.Address.Country;
        toUpdate.Address.City = clientMap.Address.City;
        toUpdate.Address.Street = clientMap.Address.Street;
        toUpdate.Address.PostalCode = clientMap.Address.PostalCode;

        dbContext.Clients.Update(toUpdate);

        await dbContext.SaveChangesAsync();

        return toUpdate; 
    }
}
