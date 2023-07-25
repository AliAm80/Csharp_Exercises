using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercise_8
{
    public static class Library
    {
        public static void DiplayBooks(Book[] books)
        {
            foreach (var book in books)
            {
                book.Info();
                Console.WriteLine("--------------"); 
            }

        }
    }
}