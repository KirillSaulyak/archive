using Archive.Core.DTOs.MovieSpace.admin.Genre;
using Archive.Core.Entities.MovieSpace;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

