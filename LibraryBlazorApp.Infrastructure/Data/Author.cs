namespace LibraryBlazorApp.Infrastructure.Data;

public class Author : Person
{
    public string Bio { get; set; } = "";
    public DateTime? BirthDate { get; set; }
    public DateTime? DeathDate { get; set; }
    public string Nationality { get; set; } = "";
    public List<Book> Books { get; set; } = new();
}
