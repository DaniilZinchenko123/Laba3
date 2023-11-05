using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolygonController
{
    public class Figure
    {
        private Point[] points;

        public Figure(Point p1, Point p2, Point p3)
        {
            points = new Point[3];
            points[0] = p1;
            points[1] = p2;
            points[2] = p3;
        }

        public Figure(Point p1, Point p2, Point p3, Point p4)
        {
            points = new Point[4];
            points[0] = p1;
            points[1] = p2;
            points[2] = p3;
            points[3] = p4;
        }

        public Figure(Point p1, Point p2, Point p3, Point p4, Point p5)
        {
            points = new Point[5];
            points[0] = p1;
            points[1] = p2;
            points[2] = p3;
            points[3] = p4;
            points[4] = p5;
        }

        public double GetSideLength(Point A, Point B)
        {
            double sideLength = Math.Sqrt(Math.Pow(B.X - A.X, 2) + Math.Pow(B.Y - A.Y, 2));
            return sideLength;
        }

        public void CalculatePerimeter()
        {
            double perimeter = 0;
            string pointNames = "";

            for (int i = 0; i < points.Length; i++)
            {
                int nextIndex = (i + 1) % points.Length;
                perimeter += GetSideLength(points[i], points[nextIndex]);
                pointNames += points[i].Name;

            }

            Console.WriteLine($"Назва багатокутника: {points.Length}-кутник {pointNames}");
            Console.WriteLine($"Периметр багатокутника: {perimeter}");
        }
    }
}
