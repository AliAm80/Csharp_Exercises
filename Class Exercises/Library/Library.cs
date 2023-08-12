using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercise_8
{
    public static class Library
    {
        // Method to display information about all the books in the library
        public static void DiplayBooks(Book[] books)
        {
            foreach (var book in books)
            {
                book.DisplayBasicInfo();
                book.GetAdditionalInfo();
                Console.WriteLine("--------------");
            }

        }
    }
}