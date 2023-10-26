using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace shapes
{
    public class Triangle : shapes
    {
     
        private double width;
        private double height;
        private double length;

        public Triangle(double width,double height,double length) //constructor
        {
            this.width = width; 
            this.height = height;
            this.length = length;
        }
       
        public double Area()
        {
            double s = (width + height + length) / 2;
            return Math.Sqrt(s * (s - width) * (s - height) * (s - length));//area of a trinagle
        }
        public double Perimeter()
        {

            return width + height + length;//perimeter of a triangle
        }
    }
}
