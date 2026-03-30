namespace LibraryBlazorApp.Application.Dto;

public class AuthorAddDto
{
    public string Name { get; set; } = "";
    public string Surname { get; set; } = "";
    public string Bio { get; set; } = "";
    public DateTime? BirthDate { get; set; }
    public DateTime? DeathDate { get; set; }
    public string Nationality { get; set; } = "";

}
