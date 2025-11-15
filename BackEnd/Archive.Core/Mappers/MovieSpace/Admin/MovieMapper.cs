using Archive.Core.DTOs.MovieSpace.Admin.Movie;
using Archive.Core.Entities.MovieSpace;
using AutoMapper;

namespace Archive.Core.Mappers.MovieSpace.Admin
{
    public class MovieMapper : Profile
    {
        public MovieMapper()
        {
            CreateMap<MovieCreateDto, Movie>()
                .ForMember(dest => dest.Actors, opt => opt.MapFrom(src => src.ActorIds.Select(id => new Actor { Id = id }).ToList()))
                .ForMember(dest => dest.Categories, opt => opt.MapFrom(src => src.CategoryIds.Select(id => new Category { Id = id }).ToList()))
                .ForMember(dest => dest.Countries, opt => opt.MapFrom(src => src.CountryIds.Select(id => new Country { Id = id }).ToList()))
                .ForMember(dest => dest.Directors, opt => opt.MapFrom(src => src.DirectorIds.Select(id => new Director { Id = id }).ToList()))
                .ForMember(dest => dest.Genres, opt => opt.MapFrom(src => src.GenreIds.Select(id => new Genre { Id = id }).ToList()))
                .ForMember(dest => dest.Themes, opt => opt.MapFrom(src => src.ThemeIds.Select(id => new Theme { Id = id }).ToList()))
                .ForMember(dest => dest.Translators, opt => opt.MapFrom(src => src.TranslatorIds.Select(id => new Translator { Id = id }).ToList()));

            CreateMap<Movie, MovieUpdateDto>()
                .ForMember(dest => dest.ActorIds,
                    opt => opt.MapFrom(src => src.Actors.Select(actor => actor.Id).ToList()))
                .ForMember(dest => dest.CategoryIds,
                    opt => opt.MapFrom(src => src.Categories.Select(category => category.Id).ToList()))
                .ForMember(dest => dest.CountryIds,
                    opt => opt.MapFrom(src => src.Countries.Select(country => country.Id).ToList()))
                .ForMember(dest => dest.DirectorIds,
                    opt => opt.MapFrom(src => src.Directors.Select(director => director.Id).ToList()))
                .ForMember(dest => dest.GenreIds,
                    opt => opt.MapFrom(src => src.Genres.Select(genre => genre.Id).ToList()))
                .ForMember(dest => dest.ThemeIds,
                    opt => opt.MapFrom(src => src.Themes.Select(theme => theme.Id).ToList()))
                .ForMember(dest => dest.TranslatorIds,
                    opt => opt.MapFrom(src => src.Translators.Select(translator => translator.Id).ToList()))
                .ReverseMap()
                .ForMember(dest => dest.Id, opt => opt.Ignore());
        }
    }
}
