namespace LibraryBlazorApp.Application.Dto;

public class BookAdminDto : BookDto
{
    public int Id { get; set; }
    public string BookStatus { get; set; } = "";
    public DateTime BookCreatedAt { get; set; }
    public DateTime BookUpdatedAt { get; set; }
    public int AuthorId { get; set; }
    public DateTime AuthorCreatedAt { get; set; }
    public string AuthorNationality { get; set; } = "";
    public string IsAuthorAlive { get; set; } = "";

}
