namespace LibraryBlazorApp.Domain.Models;

public class Loan
{
    public int Id { get; set; }
    public int LibraryCardId { get; set; }
    public LibraryCard LibraryCard { get; set; } = null!;
    public int BookId { get; set; }
    public Book Book { get; set; } = null!;
    public DateTime BorrowDate { get; set; } = DateTime.UtcNow;
    public DateTime? ReturnedDate { get; set; }

    public string ReturnedStatus() => ReturnedDate is null ? "Borrowed" : "Returned";
    public string PenaltyForDetention()
    {
        if (ReturnedDate is null)
            if ((DateTime.UtcNow - BorrowDate).TotalDays > 30)
                return "Yes";
        return "No";
    }

}