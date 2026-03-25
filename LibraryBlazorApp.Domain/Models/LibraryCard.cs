namespace LibraryBlazorApp.Domain.Models;

public class LibraryCard
{
    public int Id { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public List<Loan> Loans { get; set; } = new();
    public int ClientId { get; set; }
    public Client Client { get; set; } = null!;

}
