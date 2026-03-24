namespace LibraryBlazorApp.Domain.Models;

public class Client : Person
{
    public string Email { get; set; } = "";
    public string PhoneNumber { get; set; } = "";
    public int AddressId { get; set; }
    public Address Address { get; set; } = null!;
}
