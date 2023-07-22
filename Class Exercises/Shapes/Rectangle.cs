using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercise_3
{
    sealed class Rectangle : Shapes
    {

        public Rectangle()
        {
            Name = "Rectangle";
            Sides = 4;
            Area = "Length * Width";
            Perimeter = "(Length + Width) * 2";
        }
        

        public (int, int) GetValue()
        {
            Console.Write("Enter a length : ");
            var length = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter a width : ");
            var width = Convert.ToInt32(Console.ReadLine());
            return (length, width);

        }

        public double CalArea(int length, int width)
        {
            return length * width;
        }
        public double CalPerimeter(int length, int width)
        {
            return (length + width) * 2;
        }




    }
}