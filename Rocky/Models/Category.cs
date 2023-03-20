using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Rocky.Models
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }
        [Required]
        [DisplayName("Category name")]
        public String CategoryName { get; set; }
        [Required]
        [DisplayName("Display order")]
        [Range(0,int.MaxValue, ErrorMessage = "Display order must be greater than 0")]
        public int DisplayOrder { get; set; }
    }
}
