using Archive.Core.Abstractions.MovieSpace.Services.Admin;
using Archive.Core.DTOs.Common;
using Archive.Core.DTOs.MovieSpace.Admin.Movie;
using Archive.Movie.MVC.Areas.Admin.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Archive.Movie.MVC.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class MovieController(
        IActorService actorService,
        ICategoryService categoryService,
        ICountryService countryService,
        IDirectorService directorService,
        IGenreService genreService,
        IMovieService movieService,
        IThemeService themeService,
        ITranslatorService translatorService) : Controller
    {
        public async Task<IActionResult> Create()
        {
            MovieCreateViewModel viewModel = new()
            {
                Actors = await actorService.findAllActorInfoShortDtos(),
                Categories = await categoryService.findAllCategoryInfoShortDtos(),
                Countries = await countryService.findAllCountryInfoShortDtos(),
                Directors = await directorService.findAllDirectorInfoShortDtos(),
                Genres = await genreService.findAllGenreInfoShortDtos(),
                Themes = await themeService.findAllThemeInfoShortDtos(),
                Translators = await translatorService.findAllTranslatorInfoShortDtos()
            };
            return View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(MovieCreateDto movieCreateDto, IFormFile poster)
        {
            await movieService.CreateMovieAsync(movieCreateDto, new UploadFileDto(poster.OpenReadStream(), poster.FileName));
            return View();
        }
        public IActionResult Edit()
        {
            return View();
        }
    }
}
