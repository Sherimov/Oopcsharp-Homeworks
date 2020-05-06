using SEDC.Homework08.Collections.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Homework08.Collections.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public Category Category { get; set; }
        private static int _IdGenerator = 0;
        public Product()
        {
            _IdGenerator++;
            Id = _IdGenerator;
        }

        public string ProductInfo()
        {
            return $"ID: {Id}, Name: {Name}, Price: {Price}, Category: {Category}";
        }

         

    }

}
