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

    public async Task<Result<List<Author>>> GetAuthors()
    {
        using var dbContext = await _contextFactory.CreateDbContextAsync();

        var authors = await dbContext.Authors.ToListAsync();
        if (authors is null) return Errors.NoAuthorsAvailable;

        return authors;
    }
}
