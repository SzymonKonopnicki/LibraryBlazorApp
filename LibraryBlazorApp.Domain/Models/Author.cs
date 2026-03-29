namespace LibraryBlazorApp.Domain.Models;

public class Author : Person
{
    public string Bio { get; set; } = "";
    public DateTime? BirthDate { get; set; }
    public DateTime? DeathDate { get; set; }
    public string Nationality { get; set; } = "";
    public List<Book> Books { get; set; } = new();

    public string IsStillAlive()
    {
        if (BirthDate is null && DeathDate is null)
            return "No info";
        else if (DeathDate is not null)
            return "Dead";
        else
            return "Alive";
    }
}
