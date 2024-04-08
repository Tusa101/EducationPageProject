using EducationPageWebAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Models.Models;
using PostgreSQLData.Repository.IRepository;
using PostgreSQLDb.Repository.IRepository;

namespace EducationPageWebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ThemeController : Controller
    {
        private readonly ILogger<ThemeController> _logger;
        private readonly IArticleRepository _articleRepository;
        private readonly IThemeRepository _themeRepository;
        private readonly IUnitOfWork _unitOfWork;

        public ThemeController(ILogger<ThemeController> logger, IThemeRepository themeRepository, IArticleRepository articleRepository, IUnitOfWork unitOfWork)
        {
            _articleRepository = articleRepository;
            _themeRepository = themeRepository;
            _logger = logger;
            _unitOfWork = unitOfWork;
        }
        [HttpGet]
        [Route("GetAllThemes")]
        public async Task<ActionResult<IEnumerable<Theme>>> GetAllThemes()
        {
            var themes = await _themeRepository.GetAllAsync();
            return themes.ToList();
        }
        [HttpGet]
        [Route("GetAllThemesWithArticles")]
        public async Task<ActionResult<IEnumerable<object>>> GetAllThemesWithArticles()
        {
            var themesWithArticles = await _themeRepository.GetAllThemesWithArticles();
            return themesWithArticles.ToList();
        }
        [HttpGet]
        [Route("GetThemeWithArticles")]
        public async Task<ActionResult<IEnumerable<object>>> GetThemeWithArticles(string themeId)
        {
            var themeWithArticles = await _themeRepository.GetThemeWithArticles(themeId);
            return themeWithArticles.ToList();
        }

        [HttpGet]
        [Route("GetTheme")]
        public async Task<ActionResult<Theme>> GetTheme(string id)
        {
            var theme = await _themeRepository.GetAsync(u=>u.ThemeId == id);
            return new ObjectResult(theme);
        }
        [HttpPost]
        [Route("AddTheme")]
        public async Task<ActionResult<Theme>> AddTheme(Theme theme)
        {
            var obj = await _themeRepository.GetAsync(t => t.ThemeId == theme.ThemeId);
            if (obj == null && theme != null)
            {
                await _themeRepository.Add(theme);
                await _unitOfWork.SaveChangesAsync();
                return Ok(theme);
            }
            return BadRequest();
        }
        [HttpPut]
        [Route("UpdateTheme")]
        public async Task<ActionResult> UpdateTheme(Theme theme)
        {
            var obj = await _themeRepository.GetAsync(t => t.ThemeId == theme.ThemeId);
            if (obj != null)
            {
                obj.Name = theme.Name;
                await _themeRepository.Update(obj);
                await _unitOfWork.SaveChangesAsync();
                return Ok();
            }
            return NotFound();
        }
        [HttpDelete]
        [Route("DeleteTheme")]
        public async Task<ActionResult> DeleteTheme(string themeId)
        {
            var obj = await _themeRepository.GetAsync(t => t.ThemeId == themeId);
            if (obj != null)
            {
                await _themeRepository.Remove(obj);
                await _unitOfWork.SaveChangesAsync();
                return Ok();
            }
            return NotFound();
        }
    }
}
