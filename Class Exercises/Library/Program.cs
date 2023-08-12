using System;

namespace Exercise_8
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an array of books with different types
            Book[] libraryCatalog = new Book[]
            { new FictionBook("The Great Gatsby", "F.Scott Fitzgerald", 180, "Classic", "Fiction Book"),
              new FictionBook("Dune", "Frank Herbert", 412, "Science Fiction", "Fiction Book"),
              new NonFictionBook("Sapiens", "Yuval Noah Harari", 512, "History", "Non Fiction Book"),
              new NonFictionBook("Atomic Habits", "James Clear", 320, "Self-Help", "Non Fiction Book")
            };

            // Display information about all the books in the library
            Library.DiplayBooks(libraryCatalog);
        }
    }
}