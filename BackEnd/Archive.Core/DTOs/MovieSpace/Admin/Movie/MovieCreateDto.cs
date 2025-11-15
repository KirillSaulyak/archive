namespace Archive.Core.DTOs.MovieSpace.Admin.Movie
{
    public record MovieCreateDto(
        DateOnly? Release,
        int? Duration,
        string? Description,
        string? Name,
        string? OriginalName,
        IList<Guid>? ActorIds,
        IList<Guid>? CategoryIds,
        IList<Guid>? CountryIds,
        IList<Guid>? DirectorIds,
        IList<Guid>? GenreIds,
        IList<Guid>? ThemeIds,
        IList<Guid>? TranslatorIds);
}
