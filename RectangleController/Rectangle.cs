using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangleController
{
    public class Rectangle
    {
        private double side1;
        private double side2;

        public Rectangle(double _side1, double _side2)
        {
            side1 = _side1;
            side2 = _side2;
        }

        public double CalculateArea()
        {
            return side1 * side2;
        }

        public double CalculatePerimeter()
        {
            return 2 * (side1 + side2);
        }

        public double Area
        {
            get { return CalculateArea(); }
        }

        public double Perimeter
        {
            get { return CalculatePerimeter(); }
        }
    }
}
