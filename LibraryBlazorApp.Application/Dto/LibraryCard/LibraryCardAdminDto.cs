namespace LibraryBlazorApp.Application.Dto;

public class LibraryCardAdminDto
{
    public int Id { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public List<LoanAdminDto> Loans { get; set; } = new();
    public string ClienName { get; set; } = "";
    public string ClienSurname { get; set; } = "";
    public int ClientId { get; set; }
    public string ClienEmail { get; set; } = "";
    public string ClienPhoneNumber { get; set; } = "";
    public string CanBorrowBook { get; set; } = "";
    public string PenaltyForBorrow { get; set; } = "";
    public int QuantityOfBorrowedBook { get; set; }
}
