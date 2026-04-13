using LibraryBlazorApp.Application.Dto;
using LibraryBlazorApp.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryBlazorApp.Application.Services.Maps;

public static class LoanMapper
{
    public static LoanAdminDto ToLoanAdminDto(Loan loan)
    {
        return new LoanAdminDto()
        {
            Id = loan.Id,
            BookId = loan.BookId,
            BookTitle = loan.Book.Title,
            ReturnedStatus = loan.ReturnedStatus(),
            PenaltyForDetention = loan.PenaltyForDetention(),
            BorrowDate = loan.BorrowDate,
            ReturnedDate = loan.ReturnedDate
        };
    }
}
