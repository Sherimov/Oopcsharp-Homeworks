using SEDC.Homework08.Collections.Enums;
using SEDC.Homework08.Collections.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SEDC.Homework08.ProductDataBase
{
    public class ProductData
    {
        List<Product> products = new List<Product>
        {
                new Product() { Name =  "Keyboard", Price = 100, Category = Category.ItEquipment},
                new Product() { Name =  "Mouse", Price = 150, Category = Category.ItEquipment},
                new Product() { Name =  "Headphones", Price = 80, Category = Category.ItEquipment},
                new Product() { Name =  "Microphone", Price = 220, Category = Category.ItEquipment},
                new Product() { Name =  "Camera", Price = 1000, Category = Category.ItEquipment},
                new Product() { Name =  "Hp-580", Price = 20000, Category = Category.LapTop},
                new Product() { Name =  "Lenovo G200", Price = 18500, Category = Category.LapTop},
                new Product() { Name =  "Hp ProBook", Price = 12000, Category = Category.LapTop},
                new Product() { Name =  "Acer S1200", Price = 28000, Category = Category.LapTop},
                new Product() { Name =  "Dell MS300", Price = 74000, Category = Category.LapTop},
                new Product() { Name =  "Office 1", Price = 10200, Category = Category.PC},
                new Product() { Name =  "Office 2", Price = 12400, Category = Category.PC},
                new Product() { Name =  "Gaming", Price = 22000, Category = Category.PC},
                new Product() { Name =  "Ultra Gaming", Price = 32200, Category = Category.PC},
                new Product() { Name =  "Ultra Ultra Gaming", Price = 61600, Category = Category.PC},
                new Product() { Name =  "Alienware", Price = 128000, Category = Category.PC},
                new Product() { Name =  "Samsung Proview", Price = 56200, Category = Category.TV},
                new Product() { Name =  "LG LG420MQ8", Price = 32000, Category = Category.TV},
                new Product() { Name =  "SONY Plasma", Price = 18000, Category = Category.TV},
                new Product() { Name =  "SONY RW78OS", Price = 179999, Category = Category.TV},
                new Product() { Name =  "Samsung Oval", Price = 247999, Category = Category.TV}
        };

        public List<Product> SearchByCategory(string input)
        {
            var CategoryList = new List<Product>();
            foreach (var p in products)
            {
                if (input.ToLower() == p.Category.ToString().ToLower())
                {
                    CategoryList.Add(p);
                }
            }
            return CategoryList;
        }

        public List<Product> FilterByPriceRange(int min, int max)
        {
            var filterList = new List<Product>();
            foreach (var p in products)
            {
                if (p.Price >= min && p.Price <= max)
                {
                    filterList.Add(p);
                }
            }
            return filterList;
        }

        public List<Product> FindProductsByPartName(string input)
        {
            var PartNameList = new List<Product>();
            foreach (var p in products)
            {
                if (p.Name.Contains(input))
                {
                    PartNameList.Add(p);
                }
            }
            return PartNameList;
        }

        public List<int> GetProductsId()
        {
            List<int> idList = new List<int>();
            foreach (var p in products)
            {
                idList.Add(p.Id);
            }
            return idList;
        }

        public string GetPriceById(int id)
        {
            int price = 0;
            foreach (var p in products)
            {
                if (id == p.Id)
                {
                    price = p.Price;
                }
            }
            if (price == 0)
            {
                return "There is no such id";
            }

            return $"{price}";

        }

        public Product GetCheapestProduct()
        {
            Product cheapestProduct = products[0];
            foreach (var p in products)
            {
                if(p.Price < cheapestProduct.Price)
                {
                    cheapestProduct = p;
                }
            }
            return cheapestProduct;
        }

        public Product GetMostExpensiveProduct()
        {
            Product mostExpensiveProduct = products[0];
            foreach (var p in products)
            {
                if (p.Price > mostExpensiveProduct.Price)
                {
                    mostExpensiveProduct = p;
                }
            }
            return mostExpensiveProduct;
        }

        public List<Product> AddProduct(Product product)
        {
            products.Add(product);
            return products;
        }

        public List<Product> RemoveProduct(int id)
        {

            for (int i = 0; i < products.Count; i++)
            {
                if (id == products[i].Id)
                {
                    products.Remove(products[i]);
                }
            }
            return products;
        }
        public void PrintList()
        {
            foreach (var p in products)
            {
                Console.WriteLine(p.ProductInfo());
            }
        }

       

    }
}
