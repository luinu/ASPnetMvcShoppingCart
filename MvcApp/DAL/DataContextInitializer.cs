using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using MvcApp.Models;

namespace MvcApp.DAL
{
    public class DataContextInitializer : DropCreateDatabaseIfModelChanges<MvcAppDataContext>
    {
        protected override void Seed(MvcAppDataContext context)
        {
            var categories = new List<Category>
            {
                new Category() {Name = "Cat1" },
                new Category() {Name = "Cat2" },
                new Category() {Name = "Cat3" },
                new Category() {Name = "Cat4" },
                new Category() {Name = "Cat5" }
            };
            categories.ForEach(c => context.Categories.Add(c));
            context.SaveChanges();

            var brands = new List<Brand>
            {
                new Brand() {Name = "Brand1" },
                new Brand() {Name = "Brand2" },
                new Brand() {Name = "Brand3" },
                new Brand() {Name = "Brand4" },
                new Brand() {Name = "Brand5" }
            };
            brands.ForEach(b => context.Brands.Add(b));
            context.SaveChanges();

            var products = new List<Product>
            {
                new Product() { Name = "Product 1", Price = 100, CategoryId = 1, BrandId = 1 },
                new Product() { Name = "Product 2", Price = 200, CategoryId = 1, BrandId = 1  },
                new Product() { Name = "Product 3", Price = 140, CategoryId = 1, BrandId = 2  },
                new Product() { Name = "Product 4", Price = 230, CategoryId = 2, BrandId = 2  },
                new Product() { Name = "Product 5", Price = 10, CategoryId = 2, BrandId = 1  },
                new Product() { Name = "Product 6", Price = 199, CategoryId = 1, BrandId = 3  },
                new Product() { Name = "Product 7", Price = 100, CategoryId = 1, BrandId = 3  },
                new Product() { Name = "Product 8", Price = 110, CategoryId = 3, BrandId = 4  },
                new Product() { Name = "Product 9", Price = 140, CategoryId = 3, BrandId = 4  },
                new Product() { Name = "Product 10", Price = 500, CategoryId = 4, BrandId = 5  },
                new Product() { Name = "Product 11", Price = 450, CategoryId = 4, BrandId = 5 },
                new Product() { Name = "Product 12", Price = 1000, CategoryId = 5, BrandId = 1  },
                new Product() { Name = "Product 13", Price = 1090, CategoryId = 5, BrandId = 1  },
                new Product() { Name = "Product 14", Price = 800, CategoryId = 1, BrandId = 2 },
                new Product() { Name = "Product 15", Price = 990, CategoryId = 1, BrandId = 2  },
            };
            products.ForEach(p => context.Products.Add(p));
            context.SaveChanges();
        }
    }
}