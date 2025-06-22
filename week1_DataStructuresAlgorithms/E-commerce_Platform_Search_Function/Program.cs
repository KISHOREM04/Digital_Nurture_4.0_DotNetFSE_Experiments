using System;
using System.Collections.Generic;

class Program
{
    static List<Product> LinearSearchByCategory(Product[] products, string category)
    {
        List<Product> result = new List<Product>();
        foreach (var product in products)
        {
            if (product.Category.Equals(category, StringComparison.OrdinalIgnoreCase))
            {
                result.Add(product);
            }
        }
        return result;
    }

    static Product? BinarySearchByCategory(Product[] products, string category)
    {
        int left = 0;
        int right = products.Length - 1;

        while (left <= right)
        {
            int mid = (left + right) / 2;
            int comparison = string.Compare(products[mid].Category, category, StringComparison.OrdinalIgnoreCase);

            if (comparison == 0)
                return products[mid];
            else if (comparison < 0)
                left = mid + 1;
            else
                right = mid - 1;
        }

        return null;
    }

    static void Main()
    {
        Product[] unsortedProducts = {
            new Product(1, "Laptop", "Electronics"),
            new Product(2, "Shirt", "Fashion"),
            new Product(3, "Book", "Education"),
            new Product(4, "Phone", "Electronics"),
            new Product(5, "Shoes", "Fashion")
        };

        Product[] sortedByCategory = (Product[])unsortedProducts.Clone();
        Array.Sort(sortedByCategory, (p1, p2) => p1.Category.CompareTo(p2.Category));

        Console.WriteLine("\nLinear Search for category 'Fashion':");
        var linearResults = LinearSearchByCategory(unsortedProducts, "Fashion");
        if (linearResults.Count > 0)
        {
            foreach (var p in linearResults)
                Console.WriteLine(p);
        }
        else
        {
            Console.WriteLine("No products found in this category.");
        }

        Console.WriteLine("\nBinary Search for category 'Fashion':");
        var binaryResult = BinarySearchByCategory(sortedByCategory, "Fashion");
        if (binaryResult != null)
            Console.WriteLine(binaryResult);
        else
            Console.WriteLine("No product found in this category.");
    }
}
