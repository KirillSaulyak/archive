using Archive.Core.DTOs.MovieSpace.Admin.Genre;
using Archive.Core.Entities.MovieSpace;
using AutoMapper;

namespace Archive.Core.Mappers.MovieSpace.Admin
{
    public class GenreMapper : Profile
    {
        public GenreMapper()
        {
            CreateMap<GenreCreateDto, Genre>();

            CreateMap<Genre, GenreInfoShortDto>();

            CreateMap<Genre, GenreUpdateDto>()
                .ReverseMap()
                .ForMember(dest => dest.Id, opt => opt.Ignore());
        }
    }
}

