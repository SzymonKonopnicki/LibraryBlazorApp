using LibraryBlazorApp.Application.Dto;
using LibraryBlazorApp.Domain.Models;
using LibraryBlazorApp.Domain.Models.Results;

namespace LibraryBlazorApp.Application.Interfaces.Admin;

public interface IAdminLoanCommand
{
    public Task<Result<Loan>> CreateLoanAsync(LoanAddDto loanAdd);
    public Task<Result<Loan>> MarkAsAReturn(int loanId);
}
