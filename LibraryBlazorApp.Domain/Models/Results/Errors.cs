using LibraryBlazorApp.Domain.Models.Enums;

namespace LibraryBlazorApp.Domain.Models.Results;

public static class Errors
{
    public static Error BookNotFound { get; } = new("BookNotFound", ErrorType.NotFound, "Book not found.");
    public static Error NoBooksAvailable { get; } = new("NoBooksAvailable ", ErrorType.NotFound, "No books available.");
}