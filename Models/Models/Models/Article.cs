using System.ComponentModel.DataAnnotations;

namespace EducationPageWebAPI.Models
{
    public class Article
    {
        public Article()
        {
            ArticleId = Guid.NewGuid().ToString();
        }
        public Article(string name, string annotation, string text)
        {
            ArticleId = Guid.NewGuid().ToString();
            Name = name;
            Annotation = annotation;
            Text = text;
        }

        [Key]
        public string ArticleId { get; set; }
        [Required]
        public string Name { get; set; }
        public string Annotation { get; set; }
        public string Text { get; set; }
    }
}
