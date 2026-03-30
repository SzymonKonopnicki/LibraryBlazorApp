namespace LibraryBlazorApp.Application.Dto;

public class AuthorAdminDto : AuthorDto
{
    public string IsStillAlive { get; set; } = "";
    public string Bio { get; set; } = "";
    public DateTime? BirthDate { get; set; }
    public DateTime? DeathDate { get; set; }
    public string Nationality { get; set; } = "";
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
    public int AuthorBooksCount { get; set; }
}
