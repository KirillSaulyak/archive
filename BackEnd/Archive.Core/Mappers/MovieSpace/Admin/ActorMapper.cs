using Archive.Core.DTOs.MovieSpace.admin.Actor;
using Archive.Core.Entities.MovieSpace;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Archive.Core.Mappers.MovieSpace.Admin
{
    public class ActorMapper : Profile
    {
        public ActorMapper()
        {
            CreateMap<ActorCreateDto, Actor>();

            CreateMap<Actor, ActorUpdateDto>();

            CreateMap<ActorUpdateDto, Actor>()
                .ForMember(dest => dest.Id, opt=> opt.Ignore());
        }
    }
}
