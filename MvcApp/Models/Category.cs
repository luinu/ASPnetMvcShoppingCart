using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;

namespace MvcApp.Models
{
    public class Category
    {
        public int Id { get; set; }
        [DisplayName("Category")]
        public string Name { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}