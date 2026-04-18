using LibraryBlazorApp.Application.Dto;
using LibraryBlazorApp.Application.Interfaces.Admin;
using LibraryBlazorApp.Domain.Models;
using LibraryBlazorApp.Domain.Models.Results;
using LibraryBlazorApp.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace LibraryBlazorApp.Infrastructure.Repositories.Commands.Admin;

public class AdminLoanCommand : IAdminLoanCommand
{
    private readonly IDbContextFactory<BlazorLibraryDbContext> _dbContextFactory;
    public AdminLoanCommand(IDbContextFactory<BlazorLibraryDbContext> dbContextFactory)
    {
        _dbContextFactory = dbContextFactory;
    }

    public async Task<Result<Loan>> CreateLoanAsync(LoanAddDto loanAdd)
    {
        using var dbContext = await _dbContextFactory.CreateDbContextAsync();
        var newLoan = new Loan()
        {
            LibraryCardId = loanAdd.LibraryCardId,
            BookId = loanAdd.BookId
        };
        await dbContext.Loans.AddAsync(newLoan);
        await dbContext.SaveChangesAsync();
        newLoan = await dbContext.Loans
            .Include(l => l.Book)
            .FirstOrDefaultAsync(l => l.Id == newLoan.Id);
        if (newLoan == null) return Errors.LoanNotFound;
        return newLoan;
    }

    public async Task<Result<Loan>> MarkAsAReturn(int loanId)
    {
        using var dbContext = await _dbContextFactory.CreateDbContextAsync();
        var loan = await dbContext.Loans.FirstOrDefaultAsync(l => l.Id == loanId);
        if(loan == null) return Errors.LoanNotFound;
        var book = dbContext.Books.FirstOrDefault(b => b.Id == loan.BookId);
        if (book == null) return Errors.BookNotFound;
        book.Quantity += 1;
        loan.ReturnedDate = DateTime.UtcNow;
        dbContext.Update(book);
        dbContext.Update(loan);
        await dbContext.SaveChangesAsync();
        return loan;
    }
}
