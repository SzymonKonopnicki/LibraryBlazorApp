namespace LibraryBlazorApp.Domain.Models;

public class Book
{
    public int Id { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
    public string Title { get; set; } = "";
    public string Description { get; set; } = "";
    public int Quantity { get; set; }
    public int AuthorId { get; set; }
    public Author Author { get; set; } = null!;
    public List<Loan> Loans { get; set; } = new();

    public string GetAvailabilityStatus() => Quantity > 0 ? "Available" : "Out of stock";
}
