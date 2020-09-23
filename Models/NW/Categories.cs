using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EfMvcNorthWind.Models.NW
{
    public partial class Categories
    {
        public Categories()
        {
            Products = new HashSet<Products>();
        }

        public int CategoryId { get; set; }

        [Required (ErrorMessage = "You must enter a {0}")]
        [MaxLength(15)]
        [Display (Name = "Category")]
        public string CategoryName { get; set; }

        [Required]
        [MaxLength(16)]
        public string Description { get; set; }
        public byte[] Picture { get; set; }

        public virtual ICollection<Products> Products { get; set; }
    }
}
