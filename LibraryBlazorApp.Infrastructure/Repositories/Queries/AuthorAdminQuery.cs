using LibraryBlazorApp.Application.Interfaces;
using LibraryBlazorApp.Domain.Models;
using LibraryBlazorApp.Domain.Models.Results;
using LibraryBlazorApp.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace LibraryBlazorApp.Infrastructure.Repositories.Queries;

public class AuthorAdminQuery : IAuthorAdminQuery
{
    private readonly IDbContextFactory<BlazorLibraryDbContext> _contextFactory;
    public AuthorAdminQuery(IDbContextFactory<BlazorLibraryDbContext> contextFactory)
    {
        _contextFactory = contextFactory;
    }

    public async Task<Result<List<Author>>> GetAuthorsAsync()
    {
        using var dbContext = await _contextFactory.CreateDbContextAsync();

        var authors = await dbContext.Authors.ToListAsync();
        if (!authors.Any()) return Errors.NoAuthorsAvailable;

        return authors;
    }

    public async Task<Result<List<Author>>> GetAuthorsWithBooksAsync()
    {
        using var dbContext = await _contextFactory.CreateDbContextAsync();
        var authors = await dbContext.Authors
            .Include(a => a.Books)
            .ToListAsync();
        if (!authors.Any()) return Errors.NoAuthorsAvailable;
        return authors;
    }
}
