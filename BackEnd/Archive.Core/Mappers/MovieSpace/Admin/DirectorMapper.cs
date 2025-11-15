using Archive.Core.DTOs.MovieSpace.admin.Director;
using Archive.Core.Entities.MovieSpace;
using AutoMapper;

namespace Archive.Core.Mappers.MovieSpace.Admin
{
    public class DirectorMapper : Profile
    {
        public DirectorMapper()
        {
            CreateMap<DirectorCreateDto, Director>();

            CreateMap<Director, DirectorUpdateDto>()
                .ReverseMap()
                .ForMember(dest => dest.Id, opt => opt.Ignore());
        }
    }
}

