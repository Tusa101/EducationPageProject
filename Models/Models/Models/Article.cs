using Models.Models;
using System.ComponentModel.DataAnnotations;

namespace EducationPageWebAPI.Models
{
    public class Article
    {
        public Article()
        {
            ArticleId = Guid.NewGuid().ToString();
        }
        public Article(string name, string annotation, string text, string themeId, int inThemePostionNumber)
        {
            ArticleId = Guid.NewGuid().ToString();
            ThemeId = themeId;
            Name = name;
            Annotation = annotation;
            Text = text;
            InThemePostionNumber = inThemePostionNumber;

        }

        [Key]
        public string ArticleId { get; set; }
        [Required]
        public string Name { get; set; }
        public int InThemePostionNumber { get; set; }
        public string ThemeId { get; set; }
        public string Annotation { get; set; }
        public string Text { get; set; }
    }
}
