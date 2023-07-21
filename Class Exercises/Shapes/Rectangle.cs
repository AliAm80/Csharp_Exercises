using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercise_3
{
    public class Rectangle : Shapes
    {

        public Rectangle()
        {
            name = "Rectangle";
            sides = 4;
            area = "Length * Width";
            perimeter = "(Length + Width) * 2";
        }

        public (int, int) GetValue()
        {
            Console.Write("Enter a length : ");
            var length = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter a width : ");
            var width = Convert.ToInt32(Console.ReadLine());
            return (length, width);

        }

        public double Area(int length, int width)
        {
            return length * width;
        }
        public double Perimeter(int length, int width)
        {
            return (length + width) * 2;
        }




    }
}