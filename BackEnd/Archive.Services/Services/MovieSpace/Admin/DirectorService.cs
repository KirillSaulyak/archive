using Archive.Core.Abstractions.MovieSpace.Services.Admin;
using Archive.Core.DTOs.MovieSpace.Admin.Director;
using Archive.Core.Entities.MovieSpace;
using Archive.Core.Exceptions;
using Archive.Infrastructure.Persistence;
using AutoMapper;
using Microsoft.EntityFrameworkCore;

namespace Archive.Services.Services.MovieSpace.Admin
{
    public class DirectorService(ArchiveDbContext archiveDbContext, IMapper directorMapper) : IDirectorService
    {

        public async Task CreateDirectorAsync(DirectorCreateDto directorCreateDto)
        {
            await archiveDbContext.Directors.AddAsync(directorMapper.Map<Director>(directorCreateDto));
            await archiveDbContext.SaveChangesAsync();
        }

        public async Task<IList<DirectorInfoShortDto>> findAllDirectorInfoShortDtos()
        {
            IList<Director> directors = await archiveDbContext.Directors.AsNoTracking().ToListAsync();
            return directorMapper.Map<IList<DirectorInfoShortDto>>(directors);
        }

        public async Task<IList<Director>> FindAllDirectorByIdsTrackingAsync(IList<Guid> ids)
        {
            return await archiveDbContext.Directors.Where(director => ids.Contains(director.Id)).ToListAsync();
        }

        public async Task<DirectorUpdateDto> GetDirectorByIdForUpdateAsync(Guid id)
        {
            Director director = await archiveDbContext.Directors.AsNoTracking().FirstOrDefaultAsync(director => director.Id == id) ?? throw new EntityNotFoundException("Can`t find director with id: " + id);
            return directorMapper.Map<DirectorUpdateDto>(director);
        }

        public async Task UpdateDirectorAsync(DirectorUpdateDto directorUpdateDto)
        {
            Director director = await archiveDbContext.Directors.FindAsync(directorUpdateDto.Id) ?? throw new EntityNotFoundException("Can`t update director. Wrong id: " + directorUpdateDto.Id);
            directorMapper.Map(directorUpdateDto, director);
            await archiveDbContext.SaveChangesAsync();
        }

        public async Task<IList<Director>> GetAllDirectorsAsync()
        {
            return await archiveDbContext.Directors.AsNoTracking().ToListAsync();
        }

        public async Task DeleteDirectorById(Guid id)
        {
            Director directorForDelete = await archiveDbContext.Directors.FindAsync(id) ?? throw new EntityNotFoundException("Can`t delete director. Wrong id: " + id);
            archiveDbContext.Directors.Remove(directorForDelete);
        }
    }
}

