using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shapes
{
    public class Circle : shapes
    {
     
        private double radius;

        public Circle(double radius) { //constructor
            this.radius = radius;
          
        }

        public double calculateArea()
        {
            return Math.PI * radius * radius; // calculate area of circle
        }

        public double calculateperimeter()
        {
            return 2 * Math.PI * radius; // perimeter of a circle
        }
    }
}

