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

            Console.WriteLine("All Products:");
            var products = await context.Products.ToListAsync();
            foreach (var p in products)
            {
                Console.WriteLine($"- {p.Name} - ₹{p.Price}");
            }

            Console.WriteLine("\nProduct with ID = 1:");
            var productById = await context.Products.FindAsync(1);
            Console.WriteLine(productById != null ? $"> Found: {productById.Name}" : "> Product not found");

            Console.WriteLine("\nFirst Expensive Product (Price > ₹50,000):");
            var expensiveProduct = await context.Products.FirstOrDefaultAsync(p => p.Price > 50000);
            Console.WriteLine(expensiveProduct != null ? $"> Expensive: {expensiveProduct.Name}" : "> No expensive product found");
        }
    }
}
