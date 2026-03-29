using LibraryBlazorApp.Domain.Models.Enums;

namespace LibraryBlazorApp.Domain.Models.Results;

public static class Errors
{
    public static Error BookNotFound { get; } = new("BookNotFound", ErrorType.NotFound, "Book not found.");
    public static Error NoBooksAvailable { get; } = new("NoBooksAvailable ", ErrorType.NotFound, "No books available.");
    public static Error AuthorNotFound { get; } = new("AuthorNotFound ", ErrorType.NotFound, "No author available.");
    public static Error NoAuthorsAvailable { get; } = new("NoAuthorsAvailable ", ErrorType.NotFound, "No authors available.");
}