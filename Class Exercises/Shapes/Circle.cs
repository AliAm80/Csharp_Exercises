using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercise_3
{
    public class Circle : Shapes
    {
        public Circle()
        {
            Name = "Circle";
            Sides = 0;
            Area = "Radius * Radius * Pi";
            Perimeter = "Diameter * Pi";
        }

        public int GetValue()
        {
            Console.Write("Enter a radius : ");
            var radius = Convert.ToInt32(Console.ReadLine());
            return radius;
        }

        public double CalArea(int radius)
        {
            return Math.Round(radius * radius * Math.PI);
        }
        public double CalPerimeter(int radius)
        {
            var diameter = radius + radius;
            return Math.Round(diameter * Math.PI);
        }

    }
}