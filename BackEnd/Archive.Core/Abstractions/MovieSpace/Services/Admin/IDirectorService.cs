using Archive.Core.DTOs.MovieSpace.admin.Director;
using Archive.Core.Entities.MovieSpace;

namespace Archive.Core.Abstractions.MovieSpace.Services.admin
{
    public interface IDirectorService
    {
        Task CreateDirectorAsync(DirectorCreateDto directorCreateDto);
        Task<DirectorUpdateDto> GetDirectorByIdForUpdateAsync(Guid id);
        Task UpdateDirectorAsync(DirectorUpdateDto directorUpdateDto);
        Task<IList<Director>> GetAllDirectorsAsync();
        Task DeleteDirectorById(Guid id);
    }
}

