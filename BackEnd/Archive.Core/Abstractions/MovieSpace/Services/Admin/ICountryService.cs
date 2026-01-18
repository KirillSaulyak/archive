using Archive.Core.DTOs.MovieSpace.Admin.Country;
using Archive.Core.Entities.MovieSpace;

namespace Archive.Core.Abstractions.MovieSpace.Services.Admin
{
    public interface ICountryService
    {
        Task CreateCountryAsync(CountryCreateDto countryCreateDto);
        Task<IList<CountryInfoShortDto>> findAllCountryInfoShortDtos();
        Task<IList<Country>> FindAllCountryByIdsTrackingAsync(IList<Guid> ids);
        Task<CountryUpdateDto> GetCountryByIdForUpdateAsync(Guid id);
        Task UpdateCountryAsync(CountryUpdateDto countryUpdateDto);
        Task<IList<Country>> GetAllCountriesAsync();
        Task DeleteCountryById(Guid id);
    }
}

