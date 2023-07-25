using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercise_8
{
    public abstract class Book
    {
        protected string Title { get; set; }
        protected string Author { get; set; }
        protected int Pages { get; set; }

        public abstract void Info();
    }
}