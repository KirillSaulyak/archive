using Archive.Core.DTOs.MovieSpace.admin.Theme;
using Archive.Core.Entities.MovieSpace;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Archive.Core.Abstractions.MovieSpace.Services.admin
{
    public interface IThemeService
    {
        Task CreateThemeAsync(ThemeCreateDto themeCreateDto);
        Task<ThemeUpdateDto> GetThemeByIdForUpdateAsync(Guid id);
        Task UpdateThemeAsync(ThemeUpdateDto themeUpdateDto);
        Task<IList<Theme>> GetAllThemesAsync();
        Task DeleteThemeById(Guid id);
    }
}

