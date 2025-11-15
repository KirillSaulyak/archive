using Archive.Core.DTOs.MovieSpace.admin.Translator;
using Archive.Core.Entities.MovieSpace;
using AutoMapper;

namespace Archive.Core.Mappers.MovieSpace.Admin
{
    public class TranslatorMapper : Profile
    {
        public TranslatorMapper()
        {
            CreateMap<TranslatorCreateDto, Translator>();

            CreateMap<Translator, TranslatorUpdateDto>()
                .ReverseMap()
                .ForMember(dest => dest.Id, opt => opt.Ignore());
        }
    }
}

