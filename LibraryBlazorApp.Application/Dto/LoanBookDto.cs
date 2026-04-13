namespace LibraryBlazorApp.Application.Dto;

public class LoanBookDto
{
    public int BookId { get; set; }
    public string Name { get; set; } = "";
    public string Surname { get; set; } = "";
    public string Title { get; set; } = "";
    public int Quantity { get; set; }
}
