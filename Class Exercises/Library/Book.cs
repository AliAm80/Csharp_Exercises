using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercise_8
{
    // Abstraction : Define a base Book class with common properties and methods
    public abstract class Book
    {
        protected string Title { get; set; }
        protected string Author { get; set; }
        protected int Pages { get; set; }
         protected string Type { get; set; }

        public Book(string title_b, string author_b, int pages_b, string type_b)
        {
            Title = title_b;
            Author = author_b;
            Pages = pages_b;
            Type = type_b;
        }

        // Abstract method to get additional information about the book
        public abstract void GetAdditionalInfo();

        // Common method to display basic information about the book
        public void DisplayBasicInfo()
        {
            Console.WriteLine($"Title : {Title}");
            Console.WriteLine($"Author : {Author}");
            Console.WriteLine($"Pages : {Pages}");
            Console.WriteLine($"Type : {Type}");
        }
    }
}