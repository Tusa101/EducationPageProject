using EducationPageWebAPI.Models;
using Microsoft.AspNetCore.Mvc;
using PostgreSQLConfig;
using PostgreSQLData.Repository.IRepository;
using PostgreSQLDb.Repository;
using System.Xml.Linq;

namespace EducationPageWebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ArticleController : ControllerBase
    {
        private readonly ILogger<ArticleController> _logger;
        private readonly IArticleRepository _articleRepository;
        private readonly IUnitOfWork _unitOfWork;

        public ArticleController(ILogger<ArticleController> logger, IArticleRepository articleRepository, IUnitOfWork unitOfWork)
        {
            _articleRepository = articleRepository;
            _logger = logger;
            _unitOfWork = unitOfWork;
        }
        [HttpGet]
        [Route("GetAllArticles")]
        public async Task<ActionResult<IEnumerable<Article>>> GetAllArticles()
        {
            var objs = await _articleRepository.GetAllAsync();
            return objs.ToList();
        }
        [HttpGet]
        [Route("GetArticle")]
        public async Task<ActionResult<Article>> GetArticle(string articleId)
        {
            var obj = await _articleRepository.GetAsync(a => a.ArticleId == articleId);
            if (obj == null)
            {
                return NotFound();
            }
            return new ObjectResult(obj);
        }

        [HttpPost]
        [Route("AddArticle")]
        public async Task<ActionResult<Article>> AddArticle(Article article)
        {
            article.ArticleId = Guid.NewGuid().ToString();
            var obj = await _articleRepository.GetAsync(a => a.ArticleId == article.ArticleId);
            if (obj == null && article != null)
            {
                _articleRepository.Add(article);
                await _unitOfWork.SaveChangesAsync();
                return Ok(article);
            }
            return BadRequest();
        }

        [HttpPut]
        [Route("UpdateArticle")]
        public async Task<StatusCodeResult> UpdateArticle(string articleId, Article updatedArticle)
        {
            var obj = await _articleRepository.GetAsync(a => a.ArticleId == articleId);
            if (obj != null)
            {
                obj.Annotation = updatedArticle.Annotation;
                obj.Name = updatedArticle.Name;
                obj.Text = updatedArticle.Text;
                obj.ThemeId = updatedArticle.ThemeId;
                await _articleRepository.Update(obj);
                await _unitOfWork.SaveChangesAsync();
                return Ok();
            }
            return NotFound();
        }
        [HttpDelete]
        [Route("DeleteArticle")]
        public async Task<StatusCodeResult> DeleteArticle(string articleId)
        {
            var obj = await _articleRepository.GetAsync(a => a.ArticleId == articleId);
            if (obj != null)
            {
                _articleRepository.Remove(obj);
                await _unitOfWork.SaveChangesAsync();
                return Ok();
            }
            return NotFound();
        }
    }
}
