namespace LibraryBlazorApp.Infrastructure.Data;

public class Address
{
    public int Id { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public string City { get; set; } = "";
    public string Street { get; set; } = "";
    public string PostalCode { get; set; } = "";
    public string Country { get; set; } = "";
    public Client Client { get; set; } = null!;
}
