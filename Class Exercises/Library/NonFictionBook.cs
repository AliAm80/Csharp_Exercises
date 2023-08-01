using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercise_8
{
    public class NonFictionBook : Book
    {
       string Topic { get; set; }
        public NonFictionBook(string title, string author, int pages, string topic, string type) : base(title, author, pages, type)
        {
            Topic = topic;
        }

        public override void GetAdditionalInfo()
        {
            Console.WriteLine($"Topic : {Topic}");
        }
    }
}