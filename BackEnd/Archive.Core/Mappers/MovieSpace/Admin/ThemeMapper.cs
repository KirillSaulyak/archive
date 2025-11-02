using Archive.Core.DTOs.MovieSpace.admin.Theme;
using Archive.Core.Entities.MovieSpace;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Archive.Core.Mappers.MovieSpace.Admin
{
    public class ThemeMapper : Profile
    {
        public ThemeMapper()
        {
            CreateMap<ThemeCreateDto, Theme>();

            CreateMap<Theme, ThemeUpdateDto>()
                .ReverseMap()
                .ForMember(dest => dest.Id, opt => opt.Ignore());
        }
    }
}

