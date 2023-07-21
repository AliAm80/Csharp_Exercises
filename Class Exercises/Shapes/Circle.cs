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
            name = "Circle";
            sides = 0;
            area = "Radius * Radius * Pi";
            perimeter = "Diameter * Pi";
        }

        public int GetValue()
        {
            Console.Write("Enter a radius : ");
            var radius = Convert.ToInt32(Console.ReadLine());
            return radius;
        }

        public double Area(int radius)
        {
            return Math.Round(radius * radius * Math.PI);
        }
        public double Perimeter(int radius)
        {
            var diameter = radius + radius;
            return Math.Round(diameter * Math.PI);
        }

    }
}