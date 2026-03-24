namespace LibraryBlazorApp.Infrastructure.Data;

public class LibraryCard
{
    public int Id { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public int ClientId { get; set; }
    public Client Client { get; set; } = null!;
    public List<Loan> Loans { get; set; } = new();

}
