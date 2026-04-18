using LibraryBlazorApp.Domain.Models;

namespace LibraryBlazorApp.Application.Dto;

public class LoanAdminDto
{
    public int Id { get; set; }
    public int BookId { get; set; }
    public string BookTitle { get; set; } = "";
    public string ReturnedStatus { get; set; } = "";
    public string PenaltyForDetention { get; set; } = "";
    public DateTime BorrowDate { get; set; } = DateTime.UtcNow;
    public DateTime? ReturnedDate { get; set; }

}
