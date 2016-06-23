using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace MvcApp.Models
{
    public class Brand
    {
        public int Id { get; set; }
        [DisplayName("Brand")]
        public string Name { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}