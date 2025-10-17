using Archive.Core.Entities.Movies;
using Archive.Infrastructure;
using Archive.MVC.Extensions;
using Archive.MVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Archive.MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
     
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(Actor model)
        {
            if (!await this.IsValidAsync(model))  // Общая валидация
            {
                return View(model);  // Ошибки в view
            }

            // Сохранение (например, через EF)
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
