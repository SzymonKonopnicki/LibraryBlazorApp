namespace LibraryBlazorApp.Domain.Models;

public class Client : Person
{
    public string Email { get; set; } = "";
    public string PhoneNumber { get; set; } = "";
    public Address Address { get; set; } = null!;
    public LibraryCard LibraryCard { get; set; } = new();
}
