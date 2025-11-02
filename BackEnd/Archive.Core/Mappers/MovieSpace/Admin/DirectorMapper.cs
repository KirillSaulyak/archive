using Archive.Core.DTOs.MovieSpace.admin.Director;
using Archive.Core.Entities.MovieSpace;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

