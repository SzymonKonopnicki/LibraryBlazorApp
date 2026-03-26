using LibraryBlazorApp.Domain.Models.Enums;

namespace LibraryBlazorApp.Domain.Models.Results;

public record Error(string Id, ErrorType Type, string Description);