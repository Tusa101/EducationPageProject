using EducationPageWebAPI.Models;
using Models.Models;

namespace EducationPageMVC.ViewModels
{
    public class EducationPageViewModel
    {
        public List<Article> Articles { get; set; }
        public List<Theme> Themes { get; set; }
        public List<string> Tags { get; set; }
        public int CurrentArticleId { get; set; } = 1;
        public int CurrentThemeId { get; set; }
    }
}
