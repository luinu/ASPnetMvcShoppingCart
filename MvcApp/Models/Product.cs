using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MvcApp.Models
{
    public class Product
    {
        public int Id { get; set; }
        [Required]
        [StringLength(25)]
        public string Name { get; set; }
        [Required]
        [Range(1, 400000)]
        [DisplayFormat(DataFormatString = "{0:C2}", ApplyFormatInEditMode = true)]
        [DataType(DataType.Currency)]
        [RegularExpression(@"^([\d]{1,5}\,?[\d]{0,2})", ErrorMessage = "Dopuszczalne są tylko cyfry oraz ,")]
        public decimal Price { get; set; }
        public string Description { get; set; }
        [DisplayName("Image")]
        public string ImagePath { get; set; }
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
        public int BrandId { get; set; }
        public virtual Brand Brand { get; set; }

    }
}