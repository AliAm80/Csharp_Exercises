using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercise_3
{
    sealed class Triangle : Shapes
    {
        public Triangle()
        {
            Name = "Triangle";
            Sides = 3;
            Area = "(Base * Height)/2";
            Perimeter = "Side1 + Side2 + Side3";
        }

        public (int, int) GetValue()
        { 
            Console.Write("Enter a base : ");
            var Base = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter a height : ");
            var height = Convert.ToInt32(Console.ReadLine());
            return (Base, height);
        }
        public (int, int, int) GetValue2()
        { 
            Console.Write("Enter side1 : ");
            var side1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter side2 : ");
            var side2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter side3 : ");
            var side3 = Convert.ToInt32(Console.ReadLine());
            return (side1, side2, side3);
        }

        public double CalArea(int Base, int height)
        {
            return (Base * height) / 2;
        }
        public double CalPerimeter(int side1, int side2, int side3)
        {  
            return side1 + side2 + side3;
        }
    }
}