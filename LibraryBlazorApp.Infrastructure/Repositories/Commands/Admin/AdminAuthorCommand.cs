using LibraryBlazorApp.Application.Interfaces.Admin;
using LibraryBlazorApp.Domain.Models;
using LibraryBlazorApp.Domain.Models.Results;
using LibraryBlazorApp.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace LibraryBlazorApp.Infrastructure.Repositories.Commands.Admin;

public class AdminAuthorCommand : IAdminAuthorCommand
{
    private readonly IDbContextFactory<BlazorLibraryDbContext> _contextFactory;
    public AdminAuthorCommand(IDbContextFactory<BlazorLibraryDbContext> contextFactory)
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

    public async Task<Result<int>> DeleteAuthorAsync(List<int> ids)
    {
        using var dbContext = await _contextFactory.CreateDbContextAsync();
        var toRemove = await dbContext.Authors.Where(a => ids.Contains(a.Id)).ToListAsync();
        if (!toRemove.Any()) return Errors.NoAuthorsAvailable;
        dbContext.Authors.RemoveRange(toRemove);
        await dbContext.SaveChangesAsync();
        return toRemove.Count;
    }

    public async Task<Result<Author>> EditAuthorAsync(int authorId, Author mapAuthor)
    {
        using var dbContext = await _contextFactory.CreateDbContextAsync();
        var authorDb = dbContext.Authors.FirstOrDefault(a => a.Id == authorId);
        if (authorDb is null) return Errors.AuthorNotFound;
        authorDb.Name = mapAuthor.Name;
        authorDb.Surname = mapAuthor.Surname;
        authorDb.Bio = mapAuthor.Bio;
        authorDb.BirthDate = mapAuthor.BirthDate;
        authorDb.DeathDate = mapAuthor.DeathDate;
        authorDb.Nationality = mapAuthor.Nationality;
        authorDb.UpdatedAt = DateTime.UtcNow;
        await dbContext.SaveChangesAsync();
        return authorDb;
    }
}
