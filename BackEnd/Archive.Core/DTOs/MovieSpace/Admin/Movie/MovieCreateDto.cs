using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Archive.Core.DTOs.MovieSpace.Admin.Movie
{
    public record MovieCreateDto(
        DateOnly? Release,
        int? Duration,
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
