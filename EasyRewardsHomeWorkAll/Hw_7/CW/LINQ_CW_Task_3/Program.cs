using System;
using System.Collections.Generic;
using System.Linq;

// ----------->>> Task 3- Sort a list of products by price in ascending order using LINQ. 
namespace Task3
{
    internal class program
    {
         static void Main(string[] args)
        {
            List<Product> products = new List<Product>()
            {
                new Product{productName = "Mobile",Price = 10000},
                new Product{productName = "Laptop",Price = 50000},
                new Product{productName = "Pen",Price = 10},
                new Product{productName = "Mouse",Price = 500},
                new Product{productName = "Table",Price = 950},


            };

            var sortedProductList = products.OrderBy(p => p.Price);

            foreach (var product in sortedProductList)
            {
                Console.WriteLine($"Product: {product.productName}, Price: {product.Price}");
            }

        }
    }

    class Product
    {
        public string productName { get; set; }
        public int Price { get; set; }
    }
}