using Archive.Core.DTOs.MovieSpace.Admin.Country;
using Archive.Core.Entities.MovieSpace;
using AutoMapper;

namespace Archive.Core.Mappers.MovieSpace.Admin
{
    public class CountryMapper : Profile
    {
        public CountryMapper()
        {
            CreateMap<CountryCreateDto, Country>();

            CreateMap<Country, CountryInfoShortDto>();

            CreateMap<Country, CountryUpdateDto>()
                .ReverseMap()
                .ForMember(dest => dest.Id, opt => opt.Ignore());
        }
    }
}

