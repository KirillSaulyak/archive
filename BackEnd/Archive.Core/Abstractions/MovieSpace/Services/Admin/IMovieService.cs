using Archive.Core.DTOs.MovieSpace.Admin.Movie;
using Archive.Core.Entities.MovieSpace;

namespace Archive.Core.Abstractions.MovieSpace.Services.admin
{
    public interface IMovieService
    {
        Task CreateMovieAsync(MovieCreateDto movieCreateDto);
        Task<MovieUpdateDto> GetMovieByIdForUpdateAsync(Guid id);
        Task UpdateMovieAsync(MovieUpdateDto movieUpdateDto);
        Task DeleteMovieById(Guid id);
    }
}