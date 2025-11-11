using Archive.Core.Abstractions.MovieSpace.Services.admin;
using Archive.Core.DTOs.MovieSpace.admin.Country;
using Archive.Core.Entities.MovieSpace;
using Archive.Core.Exceptions;
using Archive.Infrastructure.Persistence;
using AutoMapper;
using Microsoft.EntityFrameworkCore;

namespace Archive.Services.Services.MovieSpace.Admin
{
    public class CountryService(ArchiveDbContext archiveDbContext, IMapper countryMapper) : ICountryService
    {
        
        public async Task CreateCountryAsync(CountryCreateDto countryCreateDto)
        {
            await archiveDbContext.Countries.AddAsync(countryMapper.Map<Country>(countryCreateDto));
            await archiveDbContext.SaveChangesAsync();
        }

        public async Task<CountryUpdateDto> GetCountryByIdForUpdateAsync(Guid id)
        {
            Country country = await archiveDbContext.Countries.AsNoTracking().FirstOrDefaultAsync(country => country.Id == id) ?? throw new EntityNotFoundException("Can`t find country with id: " + id);
            return countryMapper.Map<CountryUpdateDto>(country); 
        }
         
        public async Task UpdateCountryAsync(CountryUpdateDto countryUpdateDto)
        {
            Country country = await archiveDbContext.Countries.FindAsync(countryUpdateDto.Id) ?? throw new EntityNotFoundException("Can`t update country. Wrong id: " + countryUpdateDto.Id);
            countryMapper.Map(countryUpdateDto, country);
            await archiveDbContext.SaveChangesAsync();
        }

        public async Task<IList<Country>> GetAllCountriesAsync()
        {
            return await archiveDbContext.Countries.AsNoTracking().ToListAsync();
        }

        public async Task DeleteCountryById(Guid id)
        {
            Country countryForDelete = await archiveDbContext.Countries.FindAsync(id) ?? throw new EntityNotFoundException("Can`t delete country. Wrong id: " + id);
            archiveDbContext.Countries.Remove(countryForDelete);
        }
    }
}

