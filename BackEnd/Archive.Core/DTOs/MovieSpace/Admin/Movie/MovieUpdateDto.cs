namespace Archive.Core.DTOs.MovieSpace.Admin.Movie
{
    public record MovieUpdateDto(
        Guid Id,
        DateOnly? Release,
        int? Duration,
        string? Description,
        string? Name,
        string? OriginalName,
        string? PathToPoster,
        IList<Guid>? ActorIds,
        IList<Guid>? CategoryIds,
        IList<Guid>? CountryIds,
        IList<Guid>? DirectorIds,
        IList<Guid>? GenreIds,
        IList<Guid>? ThemeIds,
        IList<Guid>? TranslatorIds);
}
