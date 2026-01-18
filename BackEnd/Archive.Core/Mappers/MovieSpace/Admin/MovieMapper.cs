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
                .ForMember(dest => dest.Actors, opt => opt.Ignore())
                .ForMember(dest => dest.Categories, opt => opt.Ignore())
                .ForMember(dest => dest.Countries, opt => opt.Ignore())
                .ForMember(dest => dest.Directors, opt => opt.Ignore())
                .ForMember(dest => dest.Genres, opt => opt.Ignore())
                .ForMember(dest => dest.Themes, opt => opt.Ignore())
                .ForMember(dest => dest.Translators, opt => opt.Ignore());

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
