using System;
using System.Collections.Generic;

namespace ECommerceExactSearch
{

    public class Product
    {
        public int Id { get; }
        public string Name { get; }

        public Product(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }

    public class ECommercePlatform
    {
        private Dictionary<string, Product> productDictionary;

        public ECommercePlatform()
        {
            productDictionary = new Dictionary<string, Product>(StringComparer.OrdinalIgnoreCase)
            {
                { "Laptop", new Product(1, "Laptop") },
                { "Smartphone", new Product(2, "Smartphone") },
                { "Bluetooth Speaker", new Product(3, "Bluetooth Speaker") },
                { "Wireless Mouse", new Product(4, "Wireless Mouse") },
                { "Laptop Stand", new Product(5, "Laptop Stand") },
                { "USB-C Cable", new Product(6, "USB-C Cable") }
            };
        }

        public Product SearchExact(string productName)
        {
            if (productDictionary.TryGetValue(productName, out Product product))
            {
                return product;
            }
            return null;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            ECommercePlatform platform = new ECommercePlatform();

            Console.WriteLine("Enter exact product name to search:");
            string query = Console.ReadLine();

            var result = platform.SearchExact(query);

            Console.WriteLine("\nSearch Result:");
            if (result != null)
            {
                Console.WriteLine($"Product Found: {result.Name} (ID: {result.Id})");
            }
            else
            {
                Console.WriteLine("Product not found.");
            }
        }
    }
}