using Archive.Core.Abstractions.MovieSpace.Services.Admin;
using Archive.Core.DTOs.MovieSpace.Admin.Genre;
using Archive.Core.Entities.MovieSpace;
using Archive.Core.Exceptions;
using Archive.Infrastructure.Persistence;
using AutoMapper;
using Microsoft.EntityFrameworkCore;

namespace Archive.Services.Services.MovieSpace.Admin
{
    public class GenreService(ArchiveDbContext archiveDbContext, IMapper genreMapper) : IGenreService
    {

        public async Task CreateGenreAsync(GenreCreateDto genreCreateDto)
        {
            await archiveDbContext.Genres.AddAsync(genreMapper.Map<Genre>(genreCreateDto));
            await archiveDbContext.SaveChangesAsync();
        }

        public async Task<IList<GenreInfoShortDto>> findAllGenreInfoShortDtos()
        {
            IList<Genre> genres = await archiveDbContext.Genres.AsNoTracking().ToListAsync();
            return genreMapper.Map<IList<GenreInfoShortDto>>(genres);
        }

        public async Task<IList<Genre>> FindAllGenreByIdsTrackingAsync(IList<Guid> ids)
        {
            return await archiveDbContext.Genres.Where(genre => ids.Contains(genre.Id)).ToListAsync();
        }

        public async Task<GenreUpdateDto> GetGenreByIdForUpdateAsync(Guid id)
        {
            Genre genre = await archiveDbContext.Genres.AsNoTracking().FirstOrDefaultAsync(genre => genre.Id == id) ?? throw new EntityNotFoundException("Can`t find genre with id: " + id);
            return genreMapper.Map<GenreUpdateDto>(genre);
        }

        public async Task UpdateGenreAsync(GenreUpdateDto genreUpdateDto)
        {
            Genre genre = await archiveDbContext.Genres.FindAsync(genreUpdateDto.Id) ?? throw new EntityNotFoundException("Can`t update genre. Wrong id: " + genreUpdateDto.Id);
            genreMapper.Map(genreUpdateDto, genre);
            await archiveDbContext.SaveChangesAsync();
        }

        public async Task<IList<Genre>> GetAllGenresAsync()
        {
            return await archiveDbContext.Genres.AsNoTracking().ToListAsync();
        }

        public async Task DeleteGenreById(Guid id)
        {
            Genre genreForDelete = await archiveDbContext.Genres.FindAsync(id) ?? throw new EntityNotFoundException("Can`t delete genre. Wrong id: " + id);
            archiveDbContext.Genres.Remove(genreForDelete);
        }
    }
}

