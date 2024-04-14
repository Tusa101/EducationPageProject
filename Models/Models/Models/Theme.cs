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
        public Theme(string id, string name, string imagePath)
        {
            ThemeId = id;
            Name = name;
            ImagePath = imagePath;
        }

        [Key]
        public string ThemeId { get; set; }
        [Required]
        public string Name { get; set; }
        public string ImagePath { get; set; }
        //public byte[] Icon { get; set; } = null;
    }
}
