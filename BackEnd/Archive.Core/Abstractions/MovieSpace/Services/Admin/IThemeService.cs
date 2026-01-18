using Archive.Core.DTOs.MovieSpace.Admin.Theme;
using Archive.Core.Entities.MovieSpace;

namespace Archive.Core.Abstractions.MovieSpace.Services.Admin
{
    public interface IThemeService
    {
        Task CreateThemeAsync(ThemeCreateDto themeCreateDto);
        Task<IList<ThemeInfoShortDto>> findAllThemeInfoShortDtos();
        Task<IList<Theme>> FindAllThemeByIdsTrackingAsync(IList<Guid> ids);
        Task<ThemeUpdateDto> GetThemeByIdForUpdateAsync(Guid id);
        Task UpdateThemeAsync(ThemeUpdateDto themeUpdateDto);
        Task<IList<Theme>> GetAllThemesAsync();
        Task DeleteThemeById(Guid id);
    }
}

