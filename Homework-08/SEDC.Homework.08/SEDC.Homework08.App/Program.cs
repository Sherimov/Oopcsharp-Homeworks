using SEDC.Homework08.Collections.Enums;
using SEDC.Homework08.Collections.Models;
using SEDC.Homework08.ProductDataBase;
using System;
using System.Collections.Generic;

namespace SEDC.Homework08.App
{
    class Program
    {
        static void Main(string[] args)
        {

            var service = new ProductData();
            Console.WriteLine("Task1: Search by category");
            Print(service.SearchByCategory(Console.ReadLine()));

            Console.WriteLine("Min Max Price");
            Print(service.FilterByPriceRange(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine())));

            Print(service.FindProductsByPartName("tra"));
            var test = service.GetProductsId();
            foreach (var item in test)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Enter ID for getting the price");
            Console.WriteLine(service.GetPriceById(int.Parse(Console.ReadLine())));

            Console.WriteLine(service.GetCheapestProduct().ProductInfo());

            Console.WriteLine(service.GetMostExpensiveProduct().ProductInfo());

            var newProduct = new Product() { Name = "TEST", Price = 123213, Category = Category.ItEquipment };
            service.AddProduct(newProduct);
            service.PrintList();

            service.RemoveProduct(10);
            service.PrintList();




            Console.ReadLine();
        }

        public static void Print(List<Product> products)
        {
            foreach (var item in products)
            {
                Console.WriteLine(item.ProductInfo());
            }
        }
        
    }
}
