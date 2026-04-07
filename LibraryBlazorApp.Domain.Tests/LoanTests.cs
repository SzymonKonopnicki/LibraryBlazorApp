using LibraryBlazorApp.Domain.Models;

namespace LibraryBlazorApp.Domain.Tests;

public class LoanTests
{
    private static Loan CreateLoan(DateTime borrowDate, DateTime? returnedDate = null) => new Loan { BorrowDate = borrowDate, ReturnedDate = returnedDate };

    [Fact]
    public void PenaltyForDetention_BorrowDateIsTodayAndReturnedDateIsNull_ResultNo()
    {
        //arrange
        var loan = CreateLoan(DateTime.UtcNow);
        string loanResult;

        //act
        loanResult = loan.PenaltyForDetention();

        //assert
        Assert.Equal("No", loanResult);
    }
    [Fact]
    public void PenaltyForDetention_BorrowDateIs20DaysAgoReturnedDateToday_ResultNo()
    {
        //arrange
        var loan = CreateLoan(DateTime.UtcNow.AddDays(-20), DateTime.UtcNow);
        string loanResult;
        //act
        loanResult = loan.PenaltyForDetention();

        //assert
        Assert.Equal("No", loanResult);
    }

    [Fact]
    public void PenaltyForDetention_BorrowDateIs30DaysAgoReturnedDateIsToday_ResultNo()
    {
        //arrange
        string loanResult;
        var loan = CreateLoan(DateTime.UtcNow.AddDays(-30), DateTime.UtcNow);
        //act
        loanResult = loan.PenaltyForDetention();

        //assert
        Assert.Equal("No", loanResult);
    }

    [Fact]
    public void PenaltyForDetention_BorrowDateIs29DaysAgoReturnedDateIsNull_ResultNo()
    {
        //arrange
        string loanResult;
        var loan = CreateLoan(DateTime.UtcNow.AddDays(-29));

        //act
        loanResult = loan.PenaltyForDetention();

        //assert
        Assert.Equal("No", loanResult);
    }
    [Fact]
    public void PenaltyForDetention_BorrowDateIs30DaysAgoReturnedDateIsNull_ResultYes()
    {
        //arrange
        string loanResult;
        var loan = CreateLoan(DateTime.UtcNow.AddDays(-30));

        //act
        loanResult = loan.PenaltyForDetention();

        //assert
        Assert.Equal("Yes", loanResult);
    }
}
