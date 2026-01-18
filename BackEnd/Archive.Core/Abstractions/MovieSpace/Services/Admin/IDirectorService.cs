using Archive.Core.DTOs.MovieSpace.Admin.Director;
using Archive.Core.Entities.MovieSpace;

namespace Archive.Core.Abstractions.MovieSpace.Services.Admin
{
    public interface IDirectorService
    {
        Task CreateDirectorAsync(DirectorCreateDto directorCreateDto);
        Task<IList<DirectorInfoShortDto>> findAllDirectorInfoShortDtos();
        Task<IList<Director>> FindAllDirectorByIdsTrackingAsync(IList<Guid> ids);
        Task<DirectorUpdateDto> GetDirectorByIdForUpdateAsync(Guid id);
        Task UpdateDirectorAsync(DirectorUpdateDto directorUpdateDto);
        Task<IList<Director>> GetAllDirectorsAsync();
        Task DeleteDirectorById(Guid id);
    }
}

