using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Models
{
    public class Tag
    {
        public Tag()
        {
            TagId = Guid.NewGuid().ToString();
        }
        public Tag(string value)
        {
            TagId = Guid.NewGuid().ToString();
            Value = value;
        }

        [Key]
        public string TagId { get; set; }
        [Required]
        public string Value { get; set; }
    }
}

