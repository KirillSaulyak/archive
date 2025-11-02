using Archive.Core.DTOs.MovieSpace.admin.Country;
using Archive.Core.Entities.MovieSpace;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Archive.Core.Abstractions.MovieSpace.Services.admin
{
    public interface ICountryService
    {
        Task CreateCountryAsync(CountryCreateDto countryCreateDto);
        Task<CountryUpdateDto> GetCountryByIdForUpdateAsync(Guid id);
        Task UpdateCountryAsync(CountryUpdateDto countryUpdateDto);
        Task<IList<Country>> GetAllCountriesAsync();
        Task DeleteCountryById(Guid id);
    }
}

