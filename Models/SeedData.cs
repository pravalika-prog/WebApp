using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace WebApp.Models
{
    public  static class SeedData
    {
        public static void SeedDatabase(DataContext context)
        {
            
            
                context.Database.Migrate();

                if (context.Products.Count() == 0 && context.Suppliers.Count()
            == 0
            && context.Categories.Count() == 0)
            {
                Supplier s1 = new Supplier
                { Name = "Splash Dudes", city = "San Jose" };
                Supplier s2 = new Supplier
                { Name = "Soccer Town", city = "Chicago" };
                Supplier s3 = new Supplier
                { Name = "Chess Co", city = "New York" };
                Category c1 = new Category { Name = "Watersports" };
                Category c2 = new Category { Name = "Soccer" };
                Category c3 = new Category { Name = "Chess" };
                context.Products.AddRange(
                new Product
                {
                    Name = "Kayak",
                    price = 275,
                    category = c1,
                    Supplier = s1
                },
               new Product
               {
                   Name = "Lifejacket",
                   price = 48.95m,
                   category = c1,
                   Supplier = s1
               },
new Product
{
    Name = "Soccer Ball",
    price = 19.50m,
    category = c2,
    Supplier = s2
},
new Product
{
    Name = "Corner Flags",
    price = 34.95m,
    category = c2,
    Supplier = s2
},
new Product
{
    Name = "Stadium",
    price = 79500,
    category = c2,
    Supplier = s2
},
new Product
{
    Name = "Thinking Cap",
    price = 16,
    category = c3,
    Supplier = s3
},
new Product
{
    Name = "Unsteady Chair",
    price = 29.95m,
    category = c3,
    Supplier = s3
},
new Product
{
    Name = "Human Chess Board",
    price = 75,
    category = c3,
    Supplier = s3
},
new Product
{
    Name = "Bling-Bling King",
    price = 1200,
    category = c3,
    Supplier = s3
}
);
                context.SaveChanges();
            }
        }
    }
}
