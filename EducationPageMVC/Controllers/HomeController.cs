using EducationPageMVC.Models;
using EducationPageMVC.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace EducationPageMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IThemeService _themeService;
        public HomeController(ILogger<HomeController> logger, IThemeService themeService)
        {
            _themeService = themeService;
            _logger = logger;
        }

        public async Task<IActionResult> Index()
        {
            var themes = await _themeService.GetAllThemes();
            var result = themes.OrderBy(t => t.ThemeId).ToList();
            return View(result);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
