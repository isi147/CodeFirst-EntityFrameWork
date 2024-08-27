using ConsoleApp23.Context;
using ConsoleApp23.Entities;

namespace ConsoleApp23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using ShopDbContext context=new ShopDbContext();
            context.Categories.Add(new Category { Name = "Terevez", Description = "Yawilliq" });

            context.Products.Add(new Product {  Name="Kelem",CategoryId = 1});

            context.Orders.Add(new Order { Address = "Ehmedli" });

            context.SaveChanges();
        }
    }
}
