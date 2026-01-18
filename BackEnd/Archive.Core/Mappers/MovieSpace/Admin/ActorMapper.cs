using Archive.Core.DTOs.MovieSpace.Admin.Actor;
using Archive.Core.Entities.MovieSpace;
using AutoMapper;

namespace Archive.Core.Mappers.MovieSpace.Admin
{
    public class ActorMapper : Profile
    {
        public ActorMapper()
        {
            CreateMap<ActorCreateDto, Actor>();

            CreateMap<Actor, ActorInfoShortDto>();

            CreateMap<Actor, ActorUpdateDto>()
                .ReverseMap()
                .ForMember(dest => dest.Id, opt => opt.Ignore());
        }
    }
}
