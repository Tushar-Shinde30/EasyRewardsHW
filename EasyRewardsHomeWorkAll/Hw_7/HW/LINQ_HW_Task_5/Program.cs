using System;
using System.Collections.Generic;
using System.Linq;
//           ---->>> Task :- Group sales data by month and calculate the
//                                        total revenue for each month using LINQ. 
class Program
{
    static void Main()
    {
        List<Sale> sales = new List<Sale>
        {
            new Sale { SaleDate = new DateTime(2024, 1, 5), Revenue = 100 },
            new Sale { SaleDate = new DateTime(2024, 1, 15), Revenue = 150 },
            new Sale { SaleDate = new DateTime(2024, 2, 8), Revenue = 200 },
            new Sale { SaleDate = new DateTime(2024, 2, 18), Revenue = 250 },
            new Sale { SaleDate = new DateTime(2024, 3, 10), Revenue = 300 },
            new Sale { SaleDate = new DateTime(2024, 3, 20), Revenue = 350 }
        };

        var monthlyRevenue = sales.GroupBy(
            sale => new { Year = sale.SaleDate.Year, Month = sale.SaleDate.Month },
            (key, group) => new
            {
                Month = new DateTime(key.Year, key.Month, 1),
                TotalRevenue = group.Sum(s => s.Revenue)
            });

        foreach (var item in monthlyRevenue)
        {
            Console.WriteLine($"Month: {item.Month.ToString("MMMM yyyy")}, Total Revenue: {item.TotalRevenue}");
        }
    }
}

class Sale
{
    public DateTime SaleDate { get; set; }
    public decimal Revenue { get; set; }
}
