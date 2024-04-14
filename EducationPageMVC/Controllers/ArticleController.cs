using EducationPageMVC.Services.Interfaces;
using EducationPageMVC.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models.Models;

namespace EducationPageMVC.Controllers
{
    public class ArticleController : Controller
    {
        private readonly IArticleService _articleService;
        private readonly IThemeService _themeService;
        public EducationPageViewModel EducationPageViewModelProp { get; set; } = new EducationPageViewModel();
        public ArticleController(IThemeService themeService, IArticleService articleService)
        {
            _themeService = themeService;
            _articleService = articleService;
        }
        // GET: ArticleController
        [HttpGet]
        public async Task<IActionResult> Index(int themeId)
        {
            EducationPageViewModelProp = new EducationPageViewModel();
            EducationPageViewModelProp.CurrentThemeId = themeId;
            var articles = await _articleService.GetAllArticlesByThemeId(themeId);
            var themes = await _themeService.GetAllThemes();
            EducationPageViewModelProp.Articles = [.. articles.OrderBy(o => o.InThemePostionNumber)];
            EducationPageViewModelProp.Themes = themes.ToList();
            return View(EducationPageViewModelProp);
        }

        // GET: ArticleController/ChangeArticle/id
        [HttpGet]
        public async Task<IActionResult> ChangeArticle(int inThemePostionNumber, int themeId)
        {
            EducationPageViewModelProp = new EducationPageViewModel();
            EducationPageViewModelProp.CurrentThemeId = themeId;
            var articles = await _articleService.GetAllArticlesByThemeId(themeId);
            var themes = await _themeService.GetAllThemes();
            EducationPageViewModelProp.Articles = [..articles.OrderBy(o => o.InThemePostionNumber)];
            EducationPageViewModelProp.Themes = themes.ToList();
            EducationPageViewModelProp.CurrentArticleId = inThemePostionNumber;
            return View("Index", EducationPageViewModelProp);
        }

        // GET: ArticleController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ArticleController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ArticleController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ArticleController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ArticleController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ArticleController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
