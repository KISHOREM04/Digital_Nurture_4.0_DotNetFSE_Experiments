using System;
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

            var laptop = await context.Products.FirstOrDefaultAsync(p => p.Name == "Laptop");
            if (laptop != null)
            {
                Console.WriteLine($"Original Laptop Price: ₹{laptop.Price}");
                laptop.Price = 70000;
                await context.SaveChangesAsync();
                Console.WriteLine("✅ Laptop price updated to ₹70000");
            }
            else
            {
                Console.WriteLine("❌ Laptop not found.");
            }

            var riceBag = await context.Products.FirstOrDefaultAsync(p => p.Name == "Rice Bag");
            if (riceBag != null)
            {
                context.Products.Remove(riceBag);
                await context.SaveChangesAsync();
                Console.WriteLine("✅ Rice Bag deleted successfully.");
            }
            else
            {
                Console.WriteLine("❌ Rice Bag not found.");
            }
        }
    }
}
