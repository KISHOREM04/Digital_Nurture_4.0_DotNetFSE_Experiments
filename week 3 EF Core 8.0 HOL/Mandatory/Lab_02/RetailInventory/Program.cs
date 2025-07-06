using System;

namespace RetailInventory
{
    class Program
    {
        static void Main(string[] args)
        {
            using var context = new AppDbContext();
            Console.WriteLine("DbContext created successfully!");
        }
    }
}
