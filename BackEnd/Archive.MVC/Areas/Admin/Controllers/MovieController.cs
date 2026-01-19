using Archive.Core.Abstractions.MovieSpace.Services.Admin;
using Archive.Core.DTOs.Common;
using Archive.Core.DTOs.MovieSpace.Admin.Movie;
using Archive.Movie.MVC.Areas.Admin.ViewModels;
using Archive.MVC.Extensions;
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
        private async Task<MovieCreateViewModel> CreateViewModelAsync(MovieCreateDto? movieCreateDto = null, IFormFile? poster = null)
        {
            return new MovieCreateViewModel
            {
                MovieCreateDto = movieCreateDto,
                Poster = poster,
                Actors = await actorService.findAllActorInfoShortDtos(),
                Categories = await categoryService.findAllCategoryInfoShortDtos(),
                Countries = await countryService.findAllCountryInfoShortDtos(),
                Directors = await directorService.findAllDirectorInfoShortDtos(),
                Genres = await genreService.findAllGenreInfoShortDtos(),
                Themes = await themeService.findAllThemeInfoShortDtos(),
                Translators = await translatorService.findAllTranslatorInfoShortDtos()
            };
        }

        public async Task<IActionResult> Create()
        {
            return View(await CreateViewModelAsync());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(MovieCreateDto movieCreateDto, IFormFile poster)
        {
            if (poster == null || poster.Length == 0)
            {
                ModelState.AddModelError("Poster", "Постер обязателен для загрузки");
            }

            if (!await this.IsValidAsync(movieCreateDto) || !ModelState.IsValid)
            {
                return View(await CreateViewModelAsync(movieCreateDto, poster));
            }

            await movieService.CreateMovieAsync(movieCreateDto, new UploadFileDto(poster!.OpenReadStream(), poster.FileName));
            return View();
        }

        public IActionResult Edit()
        {
            return View();
        }
    }
}
