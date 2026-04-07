using LibraryBlazorApp.Domain.Models;

namespace LibraryBlazorApp.Domain.Tests;

public class LibraryCardTests
{
    private static LibraryCard CreateLibraryCard(params (DateTime loanBorrow, DateTime? loanReturned)[] tab)
    {
        return new LibraryCard()
        {
            Id = 1,
            ClientId = 1,
            Client = new Client(),
            Loans = tab.Select((t, i) => new Loan()
            {
                Id = i + 1,
                LibraryCardId = 1,
                BookId = i + 1,
                BorrowDate = t.loanBorrow,
                ReturnedDate = t.loanReturned,
            }).ToList()
        };
    }

    [Fact]
    public void CanBorrowBook_AllBookReturned_ResultYes()
    {
        //arrange
        var card = CreateLibraryCard(
            (DateTime.UtcNow.AddDays(-30), DateTime.UtcNow),
            (DateTime.UtcNow.AddDays(-20), DateTime.UtcNow),
            (DateTime.UtcNow.AddDays(-10), DateTime.UtcNow));

        //act
        var result = card.CanBorrowBook();

        //assert
        Assert.Equal("Yes", result);
    }

    [Fact]
    public void CanBorrowBook_OneFromThreeBookNotReturnedPenaltyYes_ResultNo()
    {
        //arrange
        var card = CreateLibraryCard(
            (DateTime.UtcNow.AddDays(-30), null),
            (DateTime.UtcNow.AddDays(-20), DateTime.UtcNow),
            (DateTime.UtcNow.AddDays(-10), DateTime.UtcNow));


        //act
        var result = card.CanBorrowBook();
        //assert
        Assert.Equal("No", result);
    }
    [Fact]
    public void CanBorrowBook_OneFromThreeBookNotReturnedPenaltyNo_ResultYes()
    {
        //arrange
        var card = CreateLibraryCard(
            (DateTime.UtcNow, null),
            (DateTime.UtcNow.AddDays(-10), DateTime.UtcNow),
            (DateTime.UtcNow.AddDays(-20), DateTime.UtcNow));

        //act
        var result = card.CanBorrowBook();
        //assert
        Assert.Equal("Yes", result);
    }

    [Fact]
    public void CanBorrowBook_ThreeBookBorrowedPenaltyNo_ResultNo()
    {
        //arrange
        var card = CreateLibraryCard(
            (DateTime.UtcNow, null),
            (DateTime.UtcNow, null),
            (DateTime.UtcNow, null));
        //act
        var result = card.CanBorrowBook();
        //assert
        Assert.Equal("No", result);
    }

}
