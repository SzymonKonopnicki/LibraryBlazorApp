namespace LibraryBlazorApp.Domain.Models;

public class LibraryCard
{
    public int Id { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public List<Loan> Loans { get; set; } = new();
    public int ClientId { get; set; }
    public Client Client { get; set; } = null!;

    public string CanBorrowBook()
    {
        if (Loans.Select(l => l.PenaltyForDetention()).Contains("Yes"))
            return "No";
        if (Loans.Select(l => l.ReturnedStatus()).Where(s => s == "Borrowed").Count() >= 3)
            return "No";
        return "Yes";
    }
    public string PenaltyForBorrow() => Loans.Select(l => l.PenaltyForDetention()).Where(s => s == "Yes").Any() ? "Yes" : "No";
    public int QuantityOfBorrowedBook() => Loans.Select(l => l.ReturnedStatus()).Where(s => s == "Borrowed").Count();
}
