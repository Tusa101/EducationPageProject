using EducationPageWebAPI.Models;
using Models.Models;

namespace EducationPageMVC.Services.Interfaces
{
    public interface IThemeService
    {
        Task<Theme> GetTheme();
    }
}
