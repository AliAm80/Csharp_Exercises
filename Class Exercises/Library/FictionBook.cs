using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercise_8
{
    public class FictionBook : Book
    {

        string Genre { get; set; }
        public FictionBook(string title, string author, int pages, string genre)
        {
            Title = title;
            Author = author;
            Pages = pages;
            Genre = genre;
        }
        public override void Info()
        {
            Console.WriteLine("Title : " + Title);
            Console.WriteLine("Author : " + Author);
            Console.WriteLine("Pages : " + Pages);
            Console.WriteLine("Genre : " + Genre);
        }




    }
}