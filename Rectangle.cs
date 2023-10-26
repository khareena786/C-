using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shapes
{
    public class Rectangle : shapes
    {
  
        private double width; // to hide internal details using private
        private double height;
         
        public Rectangle(double width,  double height)
        {
            this.width = width; 
            this.height = height;
        }

        public double area()
        {
            return width * height; //area of rectangle
        }
        public double perimeter() {
            return 2 * (height + width); // perimeter of rectangle
        }
   
    }
}

