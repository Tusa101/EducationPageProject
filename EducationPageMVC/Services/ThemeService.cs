using EducationPageMVC.Config;
using EducationPageMVC.Services.Interfaces;
using EducationPageWebAPI.Models;
using Models.Models;

namespace EducationPageMVC.Services
{
    public class ThemeService : IThemeService
    {
        private readonly HttpClient _httpClient;
        public const string BaseThemePath = "api/Theme/";
        public ThemeService(HttpClient httpClient)
        {
            _httpClient = httpClient ?? throw new ArgumentNullException(nameof(httpClient));
        }
        public async Task<IEnumerable<Theme>> GetAllThemes()
        {
            var response = await _httpClient.GetAsync(BaseThemePath + "GetAllThemes");
            return await response.ReadContentAsync<List<Theme>>();
        }

        public Task<Theme> GetTheme()
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Tags>> GetAllThemesTags(int themeId)
        {
            var response = await _httpClient.GetAsync(BaseThemePath + $"GetThemeTags?themeId={themeId}");
            return await response.ReadContentAsync<List<Tags>>();
        }
    }
}
