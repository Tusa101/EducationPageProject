using EducationPageMVC.Config;
using EducationPageMVC.Services.Interfaces;
using EducationPageWebAPI.Models;
using Models.Models;
using PostgreSQLConfig;

namespace EducationPageMVC.Services
{
    public class ArticleService : IArticleService
    {
        private readonly HttpClient _httpClient;
        public const string BaseArticlePath = "api/Article/";
        public ArticleService(HttpClient httpClient)
        {
            _httpClient = httpClient ?? throw new ArgumentNullException(nameof(httpClient));
        }
        public async Task<IEnumerable<Article>> GetAll()
        {
            var response = await _httpClient.GetAsync(BaseArticlePath + "GetAllArticles");
            return await response.ReadContentAsync<List<Article>>();
        }

        public async Task<IEnumerable<Article>> GetAllArticlesByThemeId(int themeId)
        {
            var response = await _httpClient.GetAsync(BaseArticlePath + $"GetAllArticlesByThemeId?themeId={themeId}");
            return await response.ReadContentAsync<List<Article>>();
        }
    }
}
