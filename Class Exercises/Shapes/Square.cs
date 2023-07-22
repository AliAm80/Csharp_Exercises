using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercise_3
{
    public class Square : Shapes
    {
        public Square()
        {
            Name = "Square";
            Sides = 4;
            Area = "Side * Side";
            Perimeter = "Side * 4";
        }

        public int GetValue()
        {
            Console.Write("Enter a side : ");
            var side = Convert.ToInt32(Console.ReadLine());
            return side;
        }

        public double CalArea(int side)
        {
            return side * side;
        }
        public double CalPerimeter(int side)
        { 
            return side * 4;
        }
    }
}