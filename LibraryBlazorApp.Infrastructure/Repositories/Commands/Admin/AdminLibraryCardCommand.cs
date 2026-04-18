using LibraryBlazorApp.Application.Interfaces.Admin;
using LibraryBlazorApp.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace LibraryBlazorApp.Infrastructure.Repositories.Commands.Admin;

public class AdminLibraryCardCommand : IAdminLibraryCardCommand
{
    private readonly IDbContextFactory<BlazorLibraryDbContext> _dbContextFactory;
    public AdminLibraryCardCommand(IDbContextFactory<BlazorLibraryDbContext> dbContextFactory)
    {
        _dbContextFactory = dbContextFactory;
    }
}
