namespace LibraryBlazorApp.Domain.Models;

public class Person
{
    public int Id { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
    public string Name { get; set; } = "";
    public string Surname { get; set; } = "";

}
