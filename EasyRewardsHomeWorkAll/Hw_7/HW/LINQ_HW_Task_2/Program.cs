using System;
using System.Collections.Generic;
using System.Linq;
//      -------->>>>>> Extended LINQ Queries <<<<<<<------
//      
//            Task 2: Implement a LINQ query to retrieve the most expensive
//                    product from a list of products.

class Program
{
    static void Main(string[] args)
    {
        List<Product> products = new List<Product>
        {
            new Product { Name = "Laptop", Price = 1200 },
            new Product { Name = "Phone", Price = 800 },
            new Product { Name = "Tablet", Price = 1500 },
            new Product { Name = "Headphones", Price = 200 },
            new Product { Name = "Keyboard", Price = 100 }
        };

        var mostExpensiveProduct = products.OrderByDescending(p => p.Price).FirstOrDefault();

        if (mostExpensiveProduct != null)
        {
            Console.WriteLine($"Most expensive product: {mostExpensiveProduct.Name}, Price: {mostExpensiveProduct.Price}");
        }
        else
        {
            Console.WriteLine("No products found.");
        }
    }
}

class Product
{
    public string Name { get; set; }
    public decimal Price { get; set; }
}
