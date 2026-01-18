using Archive.Core.DTOs.MovieSpace.Admin.Theme;
using Archive.Core.Entities.MovieSpace;
using AutoMapper;

namespace Archive.Core.Mappers.MovieSpace.Admin
{
    public class ThemeMapper : Profile
    {
        public ThemeMapper()
        {
            CreateMap<ThemeCreateDto, Theme>();

            CreateMap<Theme, ThemeInfoShortDto>();

            CreateMap<Theme, ThemeUpdateDto>()
                .ReverseMap()
                .ForMember(dest => dest.Id, opt => opt.Ignore());
        }
    }
}

