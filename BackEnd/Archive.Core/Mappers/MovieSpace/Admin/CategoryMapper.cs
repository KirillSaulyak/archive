using Archive.Core.DTOs.MovieSpace.admin.Category;
using Archive.Core.Entities.MovieSpace;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Archive.Core.Mappers.MovieSpace.Admin
{
    public class CategoryMapper : Profile
    {
        public CategoryMapper()
        {
            CreateMap<CategoryCreateDto, Category>();

            CreateMap<Category, CategoryUpdateDto>()
                .ReverseMap()
                .ForMember(dest => dest.Id, opt => opt.Ignore());
        }
    }
}

