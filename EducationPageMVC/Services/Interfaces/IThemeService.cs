using EducationPageWebAPI.Models;
using Models.Models;

namespace EducationPageMVC.Services.Interfaces
{
    public interface IThemeService
    {
        Task<Theme> GetTheme();
        Task<IEnumerable<Theme>> GetAllThemes();
        Task<IEnumerable<Tags>> GetAllThemesTags(int themeId);
    }
}
