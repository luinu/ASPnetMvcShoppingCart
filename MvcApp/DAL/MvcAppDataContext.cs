using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using MvcApp.Models;

namespace MvcApp.DAL
{
    public class MvcAppDataContext : DbContext
    {
        public MvcAppDataContext() : base("MvcAppDataContext")
        {
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Brand> Brands { get; set; }


    }
}