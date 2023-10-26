using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shapes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // object property to display the area and perimeter of a circle 
            Circle circle = new Circle(2);
            Console.WriteLine("Area of Circle: " + circle.calculateArea());
            Console.WriteLine("Perimeter of Circle: " + circle.calculateperimeter());
            //area and perimeter of a rectangle
            Rectangle rect = new Rectangle(12, 30);
            Console.WriteLine("Area of Rectangle:" +  rect.area());
            Console.WriteLine("Perimeter of Rectangle:" + rect.perimeter());
            //area and perimeter of a triangle
            Triangle tri = new Triangle(4,2,3);
            Console.WriteLine("Area of Triangle:" + tri.Area());
            Console.WriteLine("Perimeter of Trinagle:" + tri.Perimeter());
        }
    }
}
