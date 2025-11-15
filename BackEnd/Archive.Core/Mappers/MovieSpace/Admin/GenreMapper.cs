using Archive.Core.DTOs.MovieSpace.admin.Genre;
using Archive.Core.Entities.MovieSpace;
using AutoMapper;

namespace Archive.Core.Mappers.MovieSpace.Admin
{
    public class GenreMapper : Profile
    {
        public GenreMapper()
        {
            CreateMap<GenreCreateDto, Genre>();

            CreateMap<Genre, GenreUpdateDto>()
                .ReverseMap()
                .ForMember(dest => dest.Id, opt => opt.Ignore());
        }
    }
}

