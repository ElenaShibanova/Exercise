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
            double AC = CalcLineLength(points[0], points[2]);
            double AD = CalcLineLength(points[0], points[3]);
            double AE = CalcLineLength(points[0], points[4]);
            double BC = CalcLineLength(points[1], points[2]);
            double CD = CalcLineLength(points[2], points[3]);
            double DE = CalcLineLength(points[3], points[4]);


            double ABC = CalcTriangleArea(AB, BC, AC);
            double ACD = CalcTriangleArea(AC, CD, AD);
            double ADE = CalcTriangleArea(AD, DE, AE);

            double totalArea = ABC + ACD + ADE;

            Console.WriteLine(totalArea);

        }

        static double CalcTriangleArea(double side1, double side2, double side3)
        {
            double p = (side1 + side2 + side3) / 2;
            double area = Math.Sqrt(p*(p-side1)*(p-side2)*(p-side3));
            return area;
        }

        static double CalcLineLength(Point point1, Point point2)
        {
            double distX = point1.X - point2.X;
            double distY = point1.Y - point2.Y;
            double distance = Math.Sqrt(distX*distX + distY*distY);
            return distance;
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