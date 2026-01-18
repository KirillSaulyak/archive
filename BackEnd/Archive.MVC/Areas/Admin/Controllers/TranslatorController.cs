using Archive.Core.Abstractions.MovieSpace.Services.Admin;
using Archive.Core.DTOs.MovieSpace.Admin.Translator;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Archive.Movie.MVC.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class TranslatorController(ITranslatorService translatorService) : Controller
    {
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(TranslatorCreateDto translatorCreateDto)
        {
           await translatorService.CreateTranslatorAsync(translatorCreateDto);

            //Перевода на страницу в котором было открыто модальное окно создания.
            //Временное решение до момента если вдруг не захочу сделать полноценную MVC
            var referrer = Request.Headers["Referer"].ToString();
            var uri = new Uri(referrer);
            var path = uri.PathAndQuery; 
            return Redirect(path);  
        }
    }
}
