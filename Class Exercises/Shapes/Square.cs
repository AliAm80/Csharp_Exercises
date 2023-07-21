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
            name = "Square";
            sides = 4;
            area = "Side * Side";
            perimeter = "Side * 4";
        }

        public int GetValue()
        {
            Console.Write("Enter a side : ");
            var side = Convert.ToInt32(Console.ReadLine());
            return side;
        }

        public double Area(int side)
        {
            return side * side;
        }
        public double Perimeter(int side)
        { 
            return side * 4;
        }
    }
}