using System;
using System.Collections.Generic;
using System.Linq;
//           -------->>>HW-Advanced Data Manipulation:
//            Task 1: Implement a LINQ query to find the top-selling products by 
//                    category from a list of sales data.

class Program
{
    static void Main(string[] args)
    {
        List<Sale> salesData = new List<Sale>
        {
            new Sale { ProductName = "Laptop", Category = "Electronics", Quantity = 20 },
            new Sale { ProductName = "Mobile", Category = "Electronics", Quantity = 30 },
            new Sale { ProductName = "TV", Category = "Electronics", Quantity = 15 },
            new Sale { ProductName = "Shirt", Category = "Clothing", Quantity = 50 },
            new Sale { ProductName = "Jeans", Category = "Clothing", Quantity = 40 },
            new Sale { ProductName = "Dress", Category = "Clothing", Quantity = 60 }
        };

        // LINQ query to find the top-selling products by category
        var topSellingProductsByCategory = salesData
            .GroupBy(sale => sale.Category) // Group by category
            .Select(group => new
            {
                Category = group.Key,
                TopSellingProduct = group.OrderByDescending(sale => sale.Quantity).First()
            });

        // Output the top-selling products by category
        foreach (var result in topSellingProductsByCategory)
        {
            Console.WriteLine($"Category: {result.Category}, Top Selling Product: {result.TopSellingProduct.ProductName}, Quantity: {result.TopSellingProduct.Quantity}");
        }
    }
}

class Sale
{
    public string ProductName { get; set; }
    public string Category { get; set; }
    public int Quantity { get; set; }
}
