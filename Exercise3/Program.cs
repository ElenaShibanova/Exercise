using System;

namespace Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            Point[] points = new Point[5];
            points[0] = GetPointFromUser("A");
            points[1] = GetPointFromUser("B");
            points[2] = GetPointFromUser("C");
            points[3] = GetPointFromUser("D");
            points[4] = GetPointFromUser("E");

            double AB = CalcLineLength(points[0], points[1]);
            //another 6 lines

            double ABC = CalcTriangleArea(AB, BC, AC);
            // another 2 triangles

            double totalArea = ABC + ACD + ADE;

        }

        static double CalcTriangleArea(double side1, double side2, double side3)
        {
            // Formula of Heron
        }

        static double CalcLineLength(Point point1, Point point2)
        {
            // Distance between points.
        }

        static Point GetPointFromUser(string pointName)
        {
            Console.WriteLine($"Enter coordinates of point {pointName}");
            Point point = new Point();
            string[] inputs = Console.ReadLine().Split(',');
            point.X = double.Parse(inputs[0]);
            point.Y = double.Parse(inputs[1]);
            return point;
        }
    }

    public class Point
    {
        public double X;
        public double Y;
    }
}