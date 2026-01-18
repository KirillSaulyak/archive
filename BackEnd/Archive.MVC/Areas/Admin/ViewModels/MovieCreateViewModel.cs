using Archive.Core.DTOs.MovieSpace.Admin.Actor;
using Archive.Core.DTOs.MovieSpace.Admin.Category;
using Archive.Core.DTOs.MovieSpace.Admin.Country;
using Archive.Core.DTOs.MovieSpace.Admin.Director;
using Archive.Core.DTOs.MovieSpace.Admin.Genre;
using Archive.Core.DTOs.MovieSpace.Admin.Movie;
using Archive.Core.DTOs.MovieSpace.Admin.Theme;
using Archive.Core.DTOs.MovieSpace.Admin.Translator;

namespace Archive.Movie.MVC.Areas.Admin.ViewModels
{
    public class MovieCreateViewModel
    {
        public MovieCreateDto? MovieCreateDto { get; set; } = null;
        public IFormFile? Poster { get; set; } = null;
        public IList<ActorInfoShortDto> Actors { get; set; } = [];
        public IList<CategoryInfoShortDto> Categories { get; set; } = [];
        public IList<CountryInfoShortDto> Countries { get; set; } = [];
        public IList<DirectorInfoShortDto> Directors { get; set; } = [];
        public IList<GenreInfoShortDto> Genres { get; set; } = [];
        public IList<ThemeInfoShortDto> Themes { get; set; } = [];
        public IList<TranslatorInfoShortDto> Translators { get; set; } = [];
    }
}
