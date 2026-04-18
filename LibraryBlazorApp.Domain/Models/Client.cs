namespace LibraryBlazorApp.Domain.Models;

public class Client : Person
{
    public string IdentityUserId { get; set; } = "";
    public Address Address { get; set; } = null!;
    public LibraryCard LibraryCard { get; set; } = null!;
}
