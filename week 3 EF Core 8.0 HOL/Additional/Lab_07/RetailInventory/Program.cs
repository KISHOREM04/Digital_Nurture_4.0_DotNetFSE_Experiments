using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RetailInventory.Models;

namespace RetailInventory
{
    class Program
    {
        static async Task Main(string[] args)
        {
            using var context = new AppDbContext();

            var filtered = await context.Products
                .Where(p => p.Price > 1000)
                .OrderByDescending(p => (double)p.Price) 
                .ToListAsync();

            Console.WriteLine("Filtered & Sorted Products (Price > ₹1000):");
            foreach (var product in filtered)
            {
                Console.WriteLine($"- {product.Name} : ₹{product.Price}");
            }

           
            var productDTOs = await context.Products
                .Select(p => new { p.Name, p.Price })
                .ToListAsync();

            Console.WriteLine("\nProduct DTOs:");
            foreach (var dto in productDTOs)
            {
                Console.WriteLine($"- {dto.Name} : ₹{dto.Price}");
            }
        }
    }
}
