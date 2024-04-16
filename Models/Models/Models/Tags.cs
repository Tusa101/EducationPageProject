using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Models
{
    public class Tags
    {
        public Tags()
        {
            TagId = Guid.NewGuid().ToString();
        }
        public Tags(string tagId, string value)
        {
            TagId = tagId;
            Value = value;
        }

        [Key]
        public string TagId { get; set; }
        [Required]
        public string Value { get; set; }
    }
}

