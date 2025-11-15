using Archive.Core.DTOs.MovieSpace.admin.Genre;
using Archive.Core.Entities.MovieSpace;

namespace Archive.Core.Abstractions.MovieSpace.Services.admin
{
    public interface IGenreService
    {
        Task CreateGenreAsync(GenreCreateDto genreCreateDto);
        Task<GenreUpdateDto> GetGenreByIdForUpdateAsync(Guid id);
        Task UpdateGenreAsync(GenreUpdateDto genreUpdateDto);
        Task<IList<Genre>> GetAllGenresAsync();
        Task DeleteGenreById(Guid id);
    }
}

