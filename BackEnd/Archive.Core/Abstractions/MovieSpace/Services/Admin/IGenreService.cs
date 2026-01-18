using Archive.Core.DTOs.MovieSpace.Admin.Genre;
using Archive.Core.Entities.MovieSpace;

namespace Archive.Core.Abstractions.MovieSpace.Services.Admin
{
    public interface IGenreService
    {
        Task CreateGenreAsync(GenreCreateDto genreCreateDto);
        Task<IList<GenreInfoShortDto>> findAllGenreInfoShortDtos();
        Task<IList<Genre>> FindAllGenreByIdsTrackingAsync(IList<Guid> ids);
        Task<GenreUpdateDto> GetGenreByIdForUpdateAsync(Guid id);
        Task UpdateGenreAsync(GenreUpdateDto genreUpdateDto);
        Task<IList<Genre>> GetAllGenresAsync();
        Task DeleteGenreById(Guid id);
    }
}

