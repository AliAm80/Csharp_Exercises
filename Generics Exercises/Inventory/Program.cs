using System;

namespace Exercise_5
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a list of products by using generics
            List<Product<object>> inventory = new List<Product<object>>()
            {
                new Product<object>("Laptop", ProductCategory.Electronics, new ElectronicsDetails("Dell", 899.99)),
                new Product<object>("T-Shirt", ProductCategory.Clothing, new ClothingDetails("Medium", "Cotton")),
                new Product<object>("Book", ProductCategory.Books, "Introduction to C# Programming"),
                new Product<object>("Apple", ProductCategory.Foods, "Red Delicious")
            };

            // Display information about all the products in the inventory
            foreach (var product in inventory)
            {
                 Console.WriteLine("---------------------");
                 product.DisplayInfo();
                 Console.WriteLine("---------------------");  
            }
            
            

        }
    }
}