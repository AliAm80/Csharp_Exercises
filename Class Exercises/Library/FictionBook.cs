using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercise_8
{
    // Derived classes for specific book type 
    public class FictionBook : Book
    {
         string Genre { get; set; }
        public FictionBook(string title, string author, int pages, string genre, string type) : base(title, author, pages, type)
        {
            Genre = genre;
        }

        // Implementation of the abstract method for FictionBook class
        public override void GetAdditionalInfo()
        {
            Console.WriteLine($"Genre : {Genre}");
        }
    }
}