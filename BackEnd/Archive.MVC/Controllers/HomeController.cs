using Archive.Core.Abstractions.MovieSpace.Services.admin;
using Archive.Core.DTOs.Common;
using Archive.Core.DTOs.MovieSpace.admin.Actor;
using Archive.Core.DTOs.MovieSpace.Admin.Movie;
using Archive.MVC.Extensions;
using Microsoft.AspNetCore.Mvc;

namespace Archive.MVC.Controllers
{
    public class HomeController(ILogger<HomeController> logger, IMovieService movieService) : Controller
    {
        public IActionResult Index()
        {
            ViewBag.ErrorMessage = TempData["ErrorMessage"] ?? "ошибки нет";
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(IFormFile formFile, string test = "testParam")
        {
          
               
       
            //await movieService.CreateMovieAsync(new UploadFileDto(formFile.OpenReadStream(),Path.GetExtension(formFile.FileName)));
            await movieService.DeleteMovieById(new Guid());

            //if (!await this.IsValidAsync(movieService))  // Общая валидация
            //{
            //    return View(movieService);  // Ошибки в view
            //}
            // Сохранение (например, через EF)
            return View();
        }
    }
}
