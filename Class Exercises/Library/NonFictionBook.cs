using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercise_8
{
    public class NonFictionBook : Book
    {
        string Topic { get; set; }
        public NonFictionBook(string title, string author, int pages, string topic)
        {
            Title = title;
            Author = author;
            Pages = pages;
            Topic = topic;
        }

        public override void Info()
        {
            Console.WriteLine("Title : " + Title);
            Console.WriteLine("Author : " + Author);
            Console.WriteLine("Pages : " + Pages);
            Console.WriteLine("Topic : " + Topic);
        }


    }
}