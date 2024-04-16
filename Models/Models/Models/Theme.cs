using EducationPageWebAPI.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Models
{
    public class Theme
    {
        public Theme()
        {
        }
        public Theme(string id, string name, string imagePath, List<string> tagsIds)
        {
            ThemeId = id;
            Name = name;
            ImagePath = imagePath;
            TagsIds = tagsIds;
        }

        [Key]
        public string ThemeId { get; set; }
        [Required]
        public string Name { get; set; }
        public string ImagePath { get; set; }
        public List<string> TagsIds { get; set; }
    }
}
