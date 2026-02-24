using Archive.Core.Abstractions.MovieSpace.Services.Admin;
using Archive.Core.DTOs.Common;
using Archive.Core.DTOs.MovieSpace.Admin.Actor;
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
    }
}
