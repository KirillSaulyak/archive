using Archive.Core.Abstractions.MovieSpace.Services.admin;
using Archive.Core.DTOs.MovieSpace.admin.Actor;
using Archive.Core.Entities.MovieSpace;
using Archive.Infrastructure;
using Archive.MVC.Extensions;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Archive.MVC.Controllers
{
    public class HomeController(ILogger<HomeController> logger, IActorService actorService) : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(ActorCreateDto actorCreateDto)
        {
            if (!await this.IsValidAsync(actorCreateDto))  // Общая валидация
            {
                return View(actorCreateDto);  // Ошибки в view
            }
           
            await actorService.UpdateActorAsync(new ActorUpdateDto( new Guid("e8477632-5f15-4fb0-0eb3-08de11b1431a"),  "cheburek2202"));
            // Сохранение (например, через EF)
            return View();
        }
    }
}
