using Archive.Core.DTOs.MovieSpace.admin.Genre;
using Archive.Core.Entities.MovieSpace;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

