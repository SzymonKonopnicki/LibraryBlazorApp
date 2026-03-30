using LibraryBlazorApp.Application.Interfaces;
using LibraryBlazorApp.Domain.Models;
using LibraryBlazorApp.Domain.Models.Results;
using LibraryBlazorApp.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace LibraryBlazorApp.Infrastructure.Repositories.Commands;

public class AuthorAdminCommand : IAuthorAdminCommand
{
    private readonly IDbContextFactory<BlazorLibraryDbContext> _contextFactory;
    public AuthorAdminCommand(IDbContextFactory<BlazorLibraryDbContext> contextFactory)
    {
        _contextFactory = contextFactory;
    }
    public async Task<Result<Author>> AddAuthorAsync(Author author)
    {
        using var dbContext = await _contextFactory.CreateDbContextAsync();
        await dbContext.Authors.AddAsync(author);
        await dbContext.SaveChangesAsync();
        return author;
    }
}
