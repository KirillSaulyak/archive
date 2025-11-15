using Archive.Core.Abstractions.MovieSpace.Services.admin;
using Archive.Core.DTOs.MovieSpace.admin.Theme;
using Archive.Core.Entities.MovieSpace;
using Archive.Core.Exceptions;
using Archive.Infrastructure.Persistence;
using AutoMapper;
using Microsoft.EntityFrameworkCore;

namespace Archive.Services.Services.MovieSpace.Admin
{
    public class ThemeService(ArchiveDbContext archiveDbContext, IMapper themeMapper) : IThemeService
    {

        public async Task CreateThemeAsync(ThemeCreateDto themeCreateDto)
        {
            await archiveDbContext.Themes.AddAsync(themeMapper.Map<Theme>(themeCreateDto));
            await archiveDbContext.SaveChangesAsync();
        }

        public async Task<ThemeUpdateDto> GetThemeByIdForUpdateAsync(Guid id)
        {
            Theme theme = await archiveDbContext.Themes.AsNoTracking().FirstOrDefaultAsync(theme => theme.Id == id) ?? throw new EntityNotFoundException("Can`t find theme with id: " + id);
            return themeMapper.Map<ThemeUpdateDto>(theme);
        }

        public async Task UpdateThemeAsync(ThemeUpdateDto themeUpdateDto)
        {
            Theme theme = await archiveDbContext.Themes.FindAsync(themeUpdateDto.Id) ?? throw new EntityNotFoundException("Can`t update theme. Wrong id: " + themeUpdateDto.Id);
            themeMapper.Map(themeUpdateDto, theme);
            await archiveDbContext.SaveChangesAsync();
        }

        public async Task<IList<Theme>> GetAllThemesAsync()
        {
            return await archiveDbContext.Themes.AsNoTracking().ToListAsync();
        }

        public async Task DeleteThemeById(Guid id)
        {
            Theme themeForDelete = await archiveDbContext.Themes.FindAsync(id) ?? throw new EntityNotFoundException("Can`t delete theme. Wrong id: " + id);
            archiveDbContext.Themes.Remove(themeForDelete);
        }
    }
}

