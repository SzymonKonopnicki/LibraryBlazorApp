namespace LibraryBlazorApp.Application.Dto;

public class BookDto
{
    #region Author
    public string Title { get; set; } = "";
    public string Description { get; set; } = "";
    public int Quantity { get; set; }
    #endregion

    #region Author
    public string AuthorName { get; set; } = "";
    public string AuthorSurname { get; set; } = "";
    public string Bio { get; set; } = "";
    public DateTime? BirthDate { get; set; }
    public DateTime? DeathDate { get; set; }
    #endregion

}
