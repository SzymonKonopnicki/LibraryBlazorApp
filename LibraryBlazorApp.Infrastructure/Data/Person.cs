namespace LibraryBlazorApp.Infrastructure.Data;

public class Person
{
    public int Id { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public string Name { get; set; } = "";
    public string Surname { get; set; } = "";

}
