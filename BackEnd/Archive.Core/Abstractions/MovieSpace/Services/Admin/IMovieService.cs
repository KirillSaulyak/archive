using Archive.Core.DTOs.Common;
using Archive.Core.DTOs.MovieSpace.Admin.Movie;

namespace Archive.Core.Abstractions.MovieSpace.Services.Admin
{
    public interface IMovieService
    {
        Task CreateMovieAsync(MovieCreateDto movieCreateDto, UploadFileDto uploadFileDto);
        Task<MovieUpdateDto> GetMovieByIdForUpdateAsync(Guid id);
        Task UpdateMovieAsync(MovieUpdateDto movieUpdateDto, UploadFileDto? uploadFileDto);

        Task DeleteMovieById(Guid id);
    }
}